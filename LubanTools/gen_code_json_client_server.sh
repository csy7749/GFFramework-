#!/bin/zsh
WORKSPACE=..

GEN_CLIENT=${WORKSPACE}/LubanTools/Luban.ClientServer/Luban.ClientServer.dll
CONF_ROOT=${WORKSPACE}/DesignerConfigs


dotnet ${GEN_CLIENT} -j cfg --\
 -d ${CONF_ROOT}/Defines/__root__.xml \
 --input_data_dir ${CONF_ROOT}/Datas \
 --output_code_dir ../Assets/GameMain/Scripts/Hotfix/LubanTables \
 --output_data_dir ../Assets/GameMain/LubanTables/json \
 --gen_types code_cs_unity_json,data_json \
 -s all 
