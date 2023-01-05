#!/bin/bash

argument="$1"

function useage () {
echo "Invalid argument: "$argument""
echo "Useage of scriptwrapper utility"
echo "Available commands are:  "
echo " install  | run this if this is your first time using the tool"
echo " update   | run this if you already installed the tool and wish to update"
}


if [[ $argument == "install" ]]; then
    ./scripts/install-tool.sh

elif [[ $argument == "update" ]]; then
    ./scripts/update-tool.sh
else 
        useage
fi
