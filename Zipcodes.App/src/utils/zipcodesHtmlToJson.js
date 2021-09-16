const headers = ['department', 'municipality', 'postalCode', 'neighbourhood'];

export const getPostalRecordsJson = () => {
    const postalRecordsArray = getPostalRecordsArray();
    const json = JSON.stringify(postalRecordsArray);
    return json;
}

const getPostalRecordsArray = () => {
    const postalRecords = [];
    const rowsArray = getRows();

    rowsArray.forEach(row => {
        const record = {};
        const cellsArray = getCells(row);

        cellsArray.forEach((cell, index) => {
            const propName = headers[index];
            record[propName] = cell.innerText;
        })

        postalRecords.push(record);
    });

    return postalRecords;
}

const getRows = () => {
    const table = document.getElementsByClassName('wikitable')[0];
    const body = table.getElementsByTagName('tbody')[0];
    const rows = body.getElementsByTagName('tr');
    const rowsArray = Array.from(rows);

    return rowsArray;
}

const getCells = row => {
    const cells = row.getElementsByTagName('td');
    const cellsArray = Array.from(cells);
    return cellsArray;
}