import numpy as np
import math

#limites da window
xminw = -20
yminw = -20
xmaxw = 0
ymaxw = 0

#limites da viewport
xminv = 0
yminv = 0
xmaxv = 400
ymaxv = 400

def mostraPontos(pontos):
    print(pontos)

def mapeamento(p):
    xvp = (((p[0] - xminw)*(xmaxv - xminv))/(xmaxw - xminw)) + xminv
    yvp = (((p[1] - yminw)*(ymaxv - yminv))/(ymaxw - yminw)) + yminv
    print("(",xvp,",",yvp,")")

#1) Modelagem do objeto - cone
#print("\nCoordenadas do modelo")
listaPontos = []
with open('cone.obj', 'r') as reader:
    line = reader.readline()
    while line != '':
        #print(line, end='')
        line = reader.readline()
        if(line.startswith('v')):
            partes = line.split()
            vetor = np.array([float(partes[1]), float(partes[2]), float(partes[3]), 1.0])
            listaPontos.append(vetor)
mostraPontos(listaPontos)

"""
#a. Matriz de transformação do modelo
#translação
tx = 4
ty = -2
tz = 1
translacao = np.array([
    [1, 0, 0, tx],
    [0, 1, 0, ty],
    [0, 0, 1, tz],
    [0, 0, 0, 1]
])
#escala
sx = 2
sy = 3
sz = 2
escala = np.array([
    [sx, 0, 0, 0],
    [0, sy, 0, 0],
    [0, 0, sz, 0],
    [0, 0, 0, 1]    
])

#rotacao em x
angx = math.radians(30)
rotx = np.array([
    [1, 0, 0, 0],
    [0, math.cos(angx), -math.sin(angx), 0],
    [0, math.sin(angx), math.cos(angx), 0],
    [0, 0, 0, 1]    
])

#rotacao em y
angy = math.radians(45)
roty = np.array([
    [math.cos(angy), 0, math.sin(angy), 0],
    [0, 1, 0, 0],
    [-math.sin(angy), 0, math.cos(angy), 0],
    [0, 0, 0, 1]    
])

#rotacao em z
angz = math.radians(60)
rotz = np.array([
    [math.cos(angz), -math.sin(angz), 0, 0],
    [math.sin(angz), math.cos(angz), 0, 0],
    [0, 0, 1, 0],
    [0, 0, 0, 1]    
])

rotacao = rotz.dot(roty.dot(rotx))

matrizModelo = escala.dot(rotacao.dot(translacao))

#2) Coordenadas do mundo
p1u = matrizModelo.dot(p1)
p2u = matrizModelo.dot(p2)
p3u = matrizModelo.dot(p3)
p4u = matrizModelo.dot(p4)
p5u = matrizModelo.dot(p5)
p6u = matrizModelo.dot(p6)
p7u = matrizModelo.dot(p7)
p8u = matrizModelo.dot(p8)
print("\nCoordenadas do mundo")
mostraPontos(p1u, p2u ,p3u ,p4u ,p5u ,p6u ,p7u ,p8u)

#b. Matriz de Visualização
#translação da câmera
txCam = 0
tyCam = 0
tzCam = -2
#é a cena que se move em torno da câmera
translacaoCam = np.array([
    [1, 0, 0, -txCam],
    [0, 1, 0, -tyCam],
    [0, 0, 1, -tzCam],
    [0, 0, 0, 1]
])

#rotação da câmera
#rotacao em y
angyCam = 45
angyCam = math.radians(-angyCam)
rotyCam = np.array([
        [math.cos(angyCam), 0, math.sin(angyCam), 0],
        [0, 1, 0, 0],
        [-math.sin(angyCam), 0, math.cos(angyCam), 0],
        [0, 0, 0, 1]    
])

matrizVisualizacao = rotyCam.dot(translacaoCam)

#3) Coordenadas de visualização
p1v = matrizVisualizacao.dot(p1u)
p2v = matrizVisualizacao.dot(p2u)
p3v = matrizVisualizacao.dot(p3u)
p4v = matrizVisualizacao.dot(p4u)
p5v = matrizVisualizacao.dot(p5u)
p6v = matrizVisualizacao.dot(p6u)
p7v = matrizVisualizacao.dot(p7u)
p8v = matrizVisualizacao.dot(p8u)
print("\nCoordenadas de visualização")
mostraPontos(p1v, p2v ,p3v ,p4v ,p5v ,p6v ,p7v ,p8v)

#c. Matriz de projeção
#projeção perspectiva
fovy = math.radians(67.0)
aspect = 1.0
zNear = 0.1
zFar = 100

a = 1/(math.tan(fovy/2) * aspect)
b = 1/(math.tan(fovy/2))
c = (zFar+zNear)/(zNear-zFar)
d = (2*(zFar*zNear))/(zNear-zFar)

matrizProjecao = np.array([
    [a, 0, 0, 0],
    [0, b, 0, 0],
    [0, 0, c, d],
    [0, 0, -1, 0]
])

#4) Coordenadas de projeção
p1p = matrizProjecao.dot(p1v)
p2p = matrizProjecao.dot(p2v)
p3p = matrizProjecao.dot(p3v)
p4p = matrizProjecao.dot(p4v)
p5p = matrizProjecao.dot(p5v)
p6p = matrizProjecao.dot(p6v)
p7p = matrizProjecao.dot(p7v)
p8p = matrizProjecao.dot(p8v)

#divide os pontox (x,y,z,w) por w, para que o w volte a ser 1
p1p = p1p/p1p[3]
p2p = p2p/p2p[3]
p3p = p3p/p3p[3]
p4p = p4p/p4p[3]
p5p = p5p/p5p[3]
p6p = p6p/p6p[3]
p7p = p7p/p7p[3]
p8p = p8p/p8p[3]

print("\nCoordenadas de projeção")
mostraPontos(p1p, p2p ,p3p ,p4p ,p5p ,p6p ,p7p ,p8p)

print("\nCoordenadas mapeadas para o dispositivo")
print("(",p1p[0],",",p1p[1],")")
print("(",p2p[0],",",p2p[1],")")
print("(",p3p[0],",",p3p[1],")")
print("(",p4p[0],",",p4p[1],")")
print("(",p5p[0],",",p5p[1],")")
print("(",p6p[0],",",p6p[1],")")
print("(",p7p[0],",",p7p[1],")")
print("(",p8p[0],",",p8p[1],")")

#d. Mapeamento
print("\nMapeamento")
mapeamento(p1p)
mapeamento(p2p)
mapeamento(p3p)
mapeamento(p4p)
mapeamento(p5p)
mapeamento(p6p)
mapeamento(p7p)
mapeamento(p8p)
"""
