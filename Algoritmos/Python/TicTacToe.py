import random
#variaveis
Mesa = [
        [9,8,7],
        [6,5,4],
        [3,2,1]
        ]

#função jogada
def mesa(entrada_jogada):
    for row in Mesa:
        for item in row:
            print(f"{item:2}", end=" ") 
        print()

def jogada():
    mesa(Mesa)
    mov_player_linha = input("Escolha uma linha")
    mov_player_col = input("Escolha uma coluna")
    Mesa[int(mov_player_linha)][int(mov_player_col)] = "X"

def repetido():
    num = Mesa[int(linha)][int(coluna)]
    if num == "X":
        print("Selecione outro numero")

def jogadaBot():
    mesa(Mesa)
    linha = random.randint(1,9)
    coluna = random.randint(1,9)


jogada()
mesa(jogada)

