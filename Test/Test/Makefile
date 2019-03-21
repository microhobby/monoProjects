SOURCES=*.cs
BUILD_DIR=build
ASSEMBLY=test.exe
REFERENCES=System.Design,System.Windows.Forms,System.Drawing,System.Data

all: ${BUILD_DIR}/${ASSEMBLY}

${BUILD_DIR}/${ASSEMBLY}: ${SOURCES}
	mkdir -p ${BUILD_DIR}
	MCS_COLORS=disable mcs -debug -r:${REFERENCES} -out:${BUILD_DIR}/${ASSEMBLY} ${SOURCES}

run: all
	mono --debug ${BUILD_DIR}/${ASSEMBLY}
