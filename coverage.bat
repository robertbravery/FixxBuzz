"%~dp0\packages\OpenCover.4.6.519\Tools\OpenCover.Console.exe" ^
-register:user ^
-target:"%VS140COMNTOOLS%\..\IDE\mstest.exe" ^
-targetargs:"/testcontainer:\"%~dp0\FizzBuzz.Tests\bin\Debug\FizzBuzz.Tests.dll\" /resultsfile:\"%~dp0..\FizzBuzzTestResults.trx\"" ^
-filter:"+[FizzBuzz*]* -[FizzBuzz.Tests]* -[*]FizzBuzz.RouteConfig" ^
-mergebyhash ^
-skipautoprops ^
-output:"%~dp0\GeneratedReports\FizzBuzzReport.xml"