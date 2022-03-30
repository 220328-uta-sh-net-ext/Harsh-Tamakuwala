#! /bin/bash
echo
echo "Lets play fizzbuzz game!!";
echo "--------------------------";
echo 
echo "enter number less than 0 to exit from the game..."
echo
a=3;
b=5;
checkNum=0;
while (( $checkNum >= 0 ));
do
    read -p "Please enter any num: " checkNum;

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
done
