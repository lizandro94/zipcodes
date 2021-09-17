import React, { useEffect, useState } from 'react';
import { Table, Select, Card, Divider } from 'antd';
import { getPostalRecords } from '../../api/zipcodes/zipcodesClient';
import { errorNotif } from '../../utils/notifUtilities';
import './styles.scss';

const Zipcodes = () => {
    const { Option } = Select;
    const [postalRecords, setPostalRecords] = useState([]);

    const getPostalRecordsData = async () => {
        try {
            const postalRecords = await getPostalRecords();
            console.log(postalRecords);
            setPostalRecords(postalRecords);
        } catch (error) {
            errorNotif("It was not posible to get postal records");
        }
    }

    useEffect(() => {
        getPostalRecordsData();
    }, [])

    const onChangeZipcode = (value) => {
        console.log(value);
    }

    const filterOptions = (input, option) =>
        option.children.toLowerCase().indexOf(input.toLowerCase()) >= 0

    return (
        <Card className="zip-card" title="Postal information">
            <Select
                showSearch
                style={{ width: '100%' }}
                placeholder="Select a zipcode"
                optionFilterProp="children"
                onChange={onChangeZipcode}
                filterOption={filterOptions}
            >
                {postalRecords.map(record =>
                    <Option key={record.key} value={record.key}>
                        {record.displayText}
                    </Option>)}
            </Select>
            <Divider />
        </Card>
    );
};

export default Zipcodes;