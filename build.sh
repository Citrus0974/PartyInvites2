#!/bin/bash
echo "Build started"

DOCKER_BUILDKIT=1 docker build -f ./Dockerfile -t  asp-net/party-invites .
