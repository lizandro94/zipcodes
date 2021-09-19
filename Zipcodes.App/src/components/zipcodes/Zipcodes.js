import React, { useEffect, useState } from 'react';
import { Card, Divider } from 'antd';
import Filter from './Filter';
import ZipcodeDetails from './ZipcodeDetails';
import { getPostalRecords } from '../../api/zipcodes/zipcodesClient';
import { errorNotif } from '../../utils/notifUtilities';
import './styles.scss';

const Zipcodes = () => {
    const [postalRecords, setPostalRecords] = useState([]);
    const [selectedRecord, setSelectedRecord] = useState({});

    const getPostalRecordsData = async () => {
        try {
            const postalRecords = await getPostalRecords();
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

    return (
        <Card className="zip-card" title="Postal Information">
            <Filter postalRecords={postalRecords} onChangeZipcode={onChangeZipcode} />
            <Divider />
            <ZipcodeDetails selectedRecord={selectedRecord} />
        </Card>
    );
};

export default Zipcodes;