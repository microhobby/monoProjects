FROM mono as build

# add src folder
ADD . /project
WORKDIR /project

RUN apt-get -y update && apt-get install -y \
	make \
	&& apt-get clean && apt-get autoremove && rm -rf /var/lib/apt/lists/*

# build
RUN make

# multi stage put on myx
FROM matheuscastello/myx as release

COPY --from=build /project/build/test.exe .

RUN apt-get -y update && apt-get install -y \
	mono-runtime \
	libmono-system-windows-forms4.0-cil \
	&& apt-get clean && apt-get autoremove && rm -rf /var/lib/apt/lists/*

RUN echo "mono /test.exe" > ~/.xinitrc
ENV DISPLAY :0

CMD ["startx"]
