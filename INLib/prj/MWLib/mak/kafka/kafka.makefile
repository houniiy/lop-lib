################################################################
#公共参数
################################################################
MAKE_PATH=../make
include $(MAKE_PATH)/makecmd.inc

################################################################
#编译参数设置
################################################################
# 多个编译源文件目录的共同根目录
CPP_ROOT_DIR=../../../..

# 多个编译源文件目录
CPP_SRC_DIR=../../../../src/MWLib/kafka


EXLIB=../../../../../EXLib

# 包含头文件目录
DEBUG_INCS=-I../../../../inc -I$(EXLIB)/kafkabridge/src
RELEASE_INCS=-I../../../../inc -I$(EXLIB)/kafkabridge/src

# 包含库文件目录
DEBUG_LIBS=
RELEASE_LIBS=

# 输出中间文件目录
DEBUG_OUT_DIR=../../../../../MWSrcOut/cos-x86-64/kafka/debug
RELEASE_OUT_DIR=../../../../../MWSrcOut/cos-x86-64/kafka/release

# 输出目标文件目录
OUT_TARGET_DIR=../../../../lib/MWLib/cos-x86-64

# 额外的宏定义
DEBUG_DEFS=
RELEASE_DEFS=

# 编译C++文件参数
DEBUG_CXX_FLAGS=-Wno-deprecated
RELEASE_CXX_FLAGS=-Wno-deprecated

# 编译C文件参数
DEBUG_C_FLAGS=-Wno-deprecated
RELEASE_C_FLAGS=-Wno-deprecated

################################################################
#编译文件
################################################################
OBJ_CPP=$(call fun_get_cpp_src_file)
OBJ_C=
OBJ_S=

################################################################
#静态库参数设置
################################################################
# 生产静态库参数
DEBUG_LIB_FLAGS=
RELEASE_LIB_FLAGS=

# 输出静态库
DEBUG_LIB_FILE=$(OUT_TARGET_DIR)/libKafka_d.a
RELEASE_LIB_FILE=$(OUT_TARGET_DIR)/libKafka.a

################################################################
#动态库参数设置
################################################################
# 生产静态库参数
DEBUG_DLL_FLAGS=
RELEASE_DLL_FLAGS=

# 输出动态库
DEBUG_DLL_FILE=$(OUT_TARGET_DIR)/libKafka_d.so
RELEASE_DLL_FILE=$(OUT_TARGET_DIR)/libKafka.so

################################################################
#可执行文件参数设置
################################################################
# 生产静态库参数
DEBUG_EXE_FLAGS=
RELEASE_EXE_FLAGS=

# 输出静态库
DEBUG_EXE_FILE=
RELEASE_EXE_FILE=

include $(MAKE_PATH)/makeobj.inc
