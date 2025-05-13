import random
import time
valores = [
        [9,8,7],
        [6,5,4],
        [3,2,1]
        ]

def mesa():
    print(f"{valores[int(0)][int(0)]} | {valores[int(0)][int(1)]} | {valores[int(0)][int(2)]}" )
    print()
    print(f"{valores[int(1)][int(0)]} | {valores[int(1)][int(1)]} | {valores[int(1)][int(2)]}" )
    print()
    print(f"{valores[int(2)][int(0)]} | {valores[int(2)][int(1)]} | {valores[int(2)][int(2)]}" )

def jogada():
    mov_player_linha = input("Escolha uma linha ")
    mov_player_col = input("Escolha uma coluna ")
    valores[int(mov_player_linha)][int(mov_player_col)] = "X"

def jogadaBot():
    linha = random.randint(0,2)
    coluna = random.randint(0,2)
    valores[int(linha)][int(coluna)] = "O"
    

mesa()
jogada()
mesa()
time.sleep(1)
print("Minha vez!")
time.sleep(1)
print("Hmmm...")
time.sleep(1)
jogadaBot()
mesa()