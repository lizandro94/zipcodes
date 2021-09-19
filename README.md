
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
3. Make sure the start up project is `Zipcodes.Api` and Run the project (F5)

### Running Frontend
4. Open repo folder in the console
```bash
cd zipcodes/
```
5. Install dependencies
```bash
npm install
```

6. Run the development server

```bash
npm start
```

### Running Backend tests
There are two tests (one unit test and one integration test). To run the tests, in visual studio open Test Explorer and click on `Run All Tests In View`