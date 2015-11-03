FROM microsoft/aspnet:1.0.0-beta8

COPY project.json /app/
WORKDIR /app
RUN ["dnx", "--version"]
RUN ["dnu", "restore"]
COPY . /app

ENTRYPOINT ["dnx", "run"]
