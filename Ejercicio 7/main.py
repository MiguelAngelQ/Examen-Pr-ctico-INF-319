def suma(x, y):
    return a + b
def resta(x, y):
    return a - b
def multiplicacion(x, y):
    return a * b
def division(x, y):
    return a // b

if __name__ == "__main__":
    print("Introduzca un numero: ", end = "")
    a = int(input())
    print("Introduzca un numero: ", end="")
    b = int(input())

    print("La suma es           :", suma(a, b))
    print("La resta es          :", resta(a, b))
    print("La multiplicacion es :", multiplicacion(a, b))
    print("La division es       :", division(a, b))