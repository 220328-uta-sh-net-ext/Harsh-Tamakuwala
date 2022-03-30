#! /bin/bash
echo 
echo "Lets play fizzbuzz game!!";
echo "--------------------------";
echo 
echo "Please enter a num:"
read checkNum;
a=3;
b=5;
if (($checkNum % $a == 0)) && (($checkNum % $b == 0))
then 
    echo "\nfizzbuzz\n";
elif (($checkNum % $a == 0))
then 
    
    echo "\nfizz\n";
elif (($checkNum % $b == 0))
then
    echo "\nbuzz\n";
else
    echo "\nNothing\n";
fi    

