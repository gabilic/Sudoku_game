:- module(sudoku, [ispis_pocetna/2,
                   ispis_rjesenje/1,
                   provjeri_rjesenje/2]).

:- use_module(library(clpfd)).
:- use_module(library(lists)).

:- dynamic slagalica/1.

%Generira poèetnu Sudoku slagalicu i sprema ju u bazu.
generiraj(R) :-
        l(9, R), maplist(l(9), R), append(R, V),
        V ins 1..9,
        transpose(R, C),
        dijagonala(0, R, D),
        maplist(reverse, R, S), dijagonala(0, S, E),
        redak(R),
        maplist(maplist(all_distinct), [R, C, [D, E]]),
        get_time(I), J is ceil(I),
        maplist(labeling([random_value(J)]), R),
        retractall(slagalica(_)),
        asserta(slagalica(R)), !.

%Provjerava da li se lista M sastoji od L elemenata.
l(L, M) :-
        length(M, L).

%Izdvaja po tri liste i šalje ih predikatu blok/3.
redak([A, B, C|T]) :-
        blok(A, B, C), redak(T); !.

%Provjerava da li su blokovi slagalice sastavljeni od jedinstvenih vrijednosti.
blok([A, B, C|X], [D, E, F|Y], [G, H, I|Z]) :-
        all_distinct([A, B, C, D, E, F, G, H, I]),
        blok(X, Y, Z); !.

%Izdvaja elemente koji èine dijagonalu iz listi koje se nalaze u listi [H|R]
%i stavlja ih u listu [A|Z].
dijagonala(X, [H|R], [A|Z]) :-
        nth0(X, H, A),
        Y is X + 1,
        (R = [], Z = R; dijagonala(Y, R, Z)).

%Vraæa elemente iz liste.
vrati([G|_], G).
vrati([_|R], E) :-
        vrati(R, E).

%Puni listu [X|Y] sa praznim vrijednostima na odreðenim poljima slagalice
%ovisno o odabranoj razini igre.
razina([G], 9, L, [X]) :-
        (member(9, L) -> X = ''; X = G).
razina([G|R], N, L, [X|Y]) :-
        razina(R, N1, L, Y),
        N is N1 - 1,
        (member(N, L) -> X = ''; X = G).

%Vraæa poèetnu Sudoku slagalicu spremnu za rješavanje.
ispis_pocetna(X, Z) :-
        generiraj(R),
        vrati(R, Y),
        randset(Z, 9, S),
        razina(Y, _, S, K),
        vrati(K, X).

%Vraæa generiranu Sudoku slagalicu spremljenu u bazi.
ispis_rjesenje(X) :-
        slagalica(R),
        vrati(R, Y),
        vrati(Y, X).

%Izdvaja elemente iz listi i pridružuje ih varijablama.
izdvoji_liste([G1|_], [G2|_], 0, G1, G2).
izdvoji_liste([_|R1], [_|R2], I, E1, E2) :-
        izdvoji_liste(R1, R2, I1, E1, E2),
        I is I1 + 1.

%Usporeðuje vrijednosti elemenata korisnikove i generirane slagalice
%te vraæa pozicije na kojima se nalazi pogreška.
usporedba([G1|_], [G2|_], 0, K, E, G1, G2) :-
        Z is 9 * K + 0,
        (G1 = G2 -> E = ''; E = Z).
usporedba([_|R1], [_|R2], N, K, E, X1, X2) :-
        usporedba(R1, R2, N1, K, _, X1, X2),
        N is N1 + 1,
        Z is 9 * K + N,
        (X1 = X2 -> E = ''; E = Z).

%Koristi predikate za izdvajanje listi i usporedbu konaènog rješenja.
usporedi_liste(X, Y, E) :-
        izdvoji_liste(X, Y, K, X1, Y1),
        usporedba(X1, Y1, _, K, E, _, _).

%Provjerava konaèno rješenje Sudoku slagalice.
provjeri_rjesenje(X, E) :-
        slagalica(Y),
        usporedi_liste(X, Y, E).