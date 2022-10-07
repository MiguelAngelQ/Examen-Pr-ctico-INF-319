from pyswip import Prolog

prolog = Prolog()

prolog.assertz('(hermanosxy(X,Y):- progenitorxy(Z,X), progenitorxy(Z,Y), not(X==Y))')
prolog.assertz('(abuelosxy(X,Y) :- progenitorxy(X,Z), progenitorxy(Z,Y))')
prolog.assertz('(nietoxy(X,Y):-  progenitorxy(Z,X),  progenitorxy(Y,Z))')
prolog.assertz('(primosxy(X,Y):- progenitorxy(Z,X), progenitorxy(W,Y), hermanosxy(Z,W))')

prolog.assertz('progenitorxy(homero, bart)')
prolog.assertz('progenitorxy(homero, lisa)')
prolog.assertz('progenitorxy(marge, bart)')
prolog.assertz('progenitorxy(marge, lisa)')
prolog.assertz('progenitorxy(abraham, homero)')
prolog.assertz('progenitorxy(mona, homero)')
prolog.assertz('progenitorxy(abraham, herb)')
prolog.assertz('progenitorxy(mona, herb)')
prolog.assertz('hermanosxy(herb, homero)')
prolog.assertz('progenitorxy(herb, adele)')

print("\n---------relacion padres-----------")
for i in prolog.query("progenitorxy(X,Y)"):
    print(i["X"], " es el padre de ", i["Y"])
print("\n---------relacion hermanos-----------")
for i in prolog.query("hermanosxy(X,Y)"):
    print(i["X"], " es  hermano de  de ", i["Y"])
print("\n---------relacion de nietos-----------")
for i in prolog.query("nietoxy(X,Y)"):
    print(i["X"], " es  nieto  de ", i["Y"])
print("\n---------relacion de abuelos-----------")
for i in prolog.query("abuelosxy(X,Y)"):
    print(i["X"], "es el abuelo de ", i["Y"])
print("\n---------relacion de primos-----------")
for i in prolog.query("primosxy(X,Y)"):
    print(i["X"], " es  primo  de ", i["Y"])

