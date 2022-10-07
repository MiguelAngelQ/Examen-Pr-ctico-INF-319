library(datasets)
data(iris)
summary(iris)

pairs(iris[1:4],main="(ROJO=setosa,VERDE=versicolor,AZUL=virginica)",
      pch=21,  bg=c("red","green3","blue")[unclass(iris$Species)])
plot(iris)

