FROM mono:6.12.0.182-slim

# MAINTAINER Jo Shields <jo.shields@xamarin.com>
# MAINTAINER Alexander Köplinger <alkpli@microsoft.com>

RUN apt-get update \
  && apt-get install -y binutils curl mono-devel ca-certificates-mono fsharp mono-vbnc nuget referenceassemblies-pcl \
  && rm -rf /var/lib/apt/lists/* /tmp/* \
  && apt-get source -qq --print-uris acl=2.2.53-4 \
  && apt-get source -qq --print-uris adduser=Dario \
  && apt-get source -qq --print-uris apt=1.8.2.3 \
  && apt-get source -qq --print-uris attr=1:2.4.48-4 \
  && apt-get source -qq --print-uris audit=1:2.8.4-3 \
  && apt-get source -qq --print-uris base-files=10.3+deb10u13 \
  && apt-get source -qq --print-uris base-passwd=pwd123 \
  && apt-get source -qq --print-uris bash=5.0-4 \
  && apt-get source -qq --print-uris binutils=2.31.1-16 \
  && apt-get source -qq --print-uris cli-common=0.10xamarin5+debian10b1