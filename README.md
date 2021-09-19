
# Zipcodes

  
  

## Prerequisites

  

1.  [Nodejs version 14.17.6 (latest LTS) and NPM](https://nodejs.org/en/)

2.  [Git](https://git-scm.com/​)
3. [Visual studio 2019](https://visualstudio.microsoft.com/es/downloads/​)
4. .Net 5

## Steps to run locally

  
### Running Backend
1. Clone the project [zipcodes](https://github.com/lizandro94/zipcodes.git)
```bash
git clone https://github.com/lizandro94/zipcodes.git
```
2. Navigate to repo folder (zipcodes) and open solution (Zipcodes.sln) with visual studio
3. Make sure the start up project is `src/API/Zipcodes.Api` and Run the project (F5)
4. Make sure the application is running on https://localhost:44374/ if the port is different please update this file `zipcodes\Zipcodes.App\src\assets\config.json`to match the url where the app is running

### Running Frontend
5. Open react app folder in the console
```bash
cd zipcodes/Zipcodes.App
```
6. Install dependencies
```bash
npm install
```

7. Run the development server

```bash
npm start
```

### Running Backend tests
There are two tests (one unit test and one integration test). To run the tests, in visual studio open Test Explorer and click on `Run All Tests In View`