PHP Integration Snippet
-----------------------

The integration snippet uses Unirest-PHP, which requires PHP v5.3+. Also you
must have curl and libcurl and php-curl libraries. As an example, in Ubuntu
you can run the following commands to install those dependencies::

   $ sudo apt-get install php5 libapache2-mod-php5
   
   $ sudo apt-get install php5-cli
   
   $ sudo apt-get install curl libcurl3 libcurl3-dev php5-curl

Assuming that you have PHP CLI installed in your system, you can run the
application in a terminal/console by executing::

   $ php php_intagration.php
      
**References:**
- https://help.ubuntu.com/10.04/serverguide/php5.html
- http://unirest.io/php.html
