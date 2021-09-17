import React, { useEffect, useState } from 'react';
import { Descriptions, Statistic, Select, Card, Divider } from 'antd';
import { getPostalRecords } from '../../api/zipcodes/zipcodesClient';
import { errorNotif } from '../../utils/notifUtilities';
import './styles.scss';

const Zipcodes = () => {
    const { Option } = Select;
    const { Item } = Descriptions;
    const [postalRecords, setPostalRecords] = useState([]);
    const [selectedRecord, setSelectedRecord] = useState({});

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
        const selected = postalRecords.find(r => r.key === value);
        setSelectedRecord(selected);
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
            <Descriptions title={<h1>Zipcode detail</h1>}>
                <Item label=""><Statistic title="Zipcode" valueStyle={{ color: '#3f8600' }} value={selectedRecord?.zipcode ?? '-'} /></Item>
                <Item label=""><Statistic title="Department" value={selectedRecord.department ?? '-'} /></Item>
                <Item label=""><Statistic title="Municipality" value={selectedRecord.municipality ?? '-'} /></Item>
                <Item label=""><Statistic title="Neighborhood" value={selectedRecord?.neighbourhood ?? '-'} /></Item>
            </Descriptions>
        </Card>
    );
};

export default Zipcodes;