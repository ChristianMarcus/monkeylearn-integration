Java Integration Snippet
------------------------

**Install Maven:**

Extract the distribution archive, i.e. apache-maven-3.2.1-bin.tar.gz to the
directory you wish to install Maven 3.2.1. These instructions assume you chose
/usr/local/apache-maven. The subdirectory apache-maven-3.2.1 will be created
from the archive.

- In a command terminal, add the M2_HOME environment variable,
  e.g. export M2_HOME=/usr/local/apache-maven/apache-maven-3.2.1.
- Add the M2 environment variable, e.g. export M2=$M2_HOME/bin.
- Optional: Add the MAVEN_OPTS environment variable to specify JVM properties,
  e.g. export MAVEN_OPTS="-Xms256m -Xmx512m".
  This environment variable can be used to supply extra options to Maven.
- Add M2 environment variable to your path, e.g. export PATH=$M2:$PATH.
- Make sure that JAVA_HOME is set to the location of your JDK,
  e.g. export JAVA_HOME=/usr/java/jdk1.7.0_51 and that $JAVA_HOME/bin is in
  your PATH environment variable.
- Run mvn --version to verify that it is correctly installed.


The *pom.xml* file has all the dependencies to build and package the application.

Under the folder that contains the *pom.xml* file, run the following command to
build and package the application::

   $ mvn package

Run the following command to execute the application::

   $ mvn exec:java

**References:**

- http://maven.apache.org/download.cgi#Installation
- http://maven.apache.org/guides/getting-started/maven-in-five-minutes.html
- http://unirest.io/java.html
