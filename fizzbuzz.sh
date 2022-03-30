#! /bin/bash
echo
echo "Lets play fizzbuzz game!!";
echo "--------------------------";
echo 
echo "enter number less than 0 to exit from the game..."
echo

checkNum=0;
while (( $checkNum >= 0 ));
do
    read -p "Please enter any num: " checkNum;

    if (($checkNum % 3 == 0)) && (($checkNum % 5 == 0))
    then 
        echo "\nfizzbuzz\n";
    elif (($checkNum % 3 == 0))
    then 
        
        echo "\nfizz\n";
    elif (($checkNum % 5 == 0))
    then
        echo "\nbuzz\n";
    else
        echo "\nNothing\n";
    fi    
done
