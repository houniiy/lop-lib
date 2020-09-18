//////////////////////////////////////////////////////////////////////
//  created:    2015/07/16
//  filename:   BCLib/utility/io/csvReader.h
//  author:     League of Perfect
/// @brief
///
//////////////////////////////////////////////////////////////////////
#ifndef __SHLIB_UTILITY_CSVREADER_H__
#define __SHLIB_UTILITY_CSVREADER_H__

#include <BCLib/utility/baseDec.h>
#include <BCLib/utility/string.h>

namespace BCLib
{
namespace Utility
{
typedef std::vector<BCLib::CString> ColList;
class CColList
{
public:
	int Size()
	{
		return m_colList.size();
	}

	BCLib::CString& operator[](int i)
	{
		return m_colList[i];
	}

	void Add(const BCLib::CString& data)
	{
		m_colList.push_back(data);
	}
private:
	ColList m_colList;
};

typedef std::vector<CColList> CRowList;
class CCsvReader
{
public:
	CCsvReader(void);

	~CCsvReader(void);

	CCsvReader(BCLib::CString fileName);

	const BCLib::CString& GetFileName();

	void SetFilename(const BCLib::CString& value);

	/// @brief ��ȡ����
	int GetRowCount();

	/// @brief ��ȡ����
	int GetColCount();

	/// @brief ��ȡĳ��ĳ�е�����
	/// @param row ����, =1 ��һ��
	/// @param col ����, =1 ��һ��
	const BCLib::CString& GetCellData(int row, int col);

	/// @brief ��ȡĳ�е�����
	/// @return row ����, = 1 ��һ��
	const CColList& GetRowData(int row);

	/// @brief ��ȡ�ļ�
	virtual bool Load(const BCLib::CString& fileName);

	/// @brief ��ȡCsv�ַ���
	virtual bool LoadCsv(const BCLib::CString& csv);

private:
	/// @brief ��������Ƿ���Чsss
	void _checkRowValid(int row);
	/// @brief ��������Ƿ���Ч
	void _checkColValid(int col);
	/// @brief �����������Ƿ���Ч
	void _checkMaxColValid(int maxCol);
	/// @brief ����CSV�ļ�
	bool _loadCsvFile(std::basic_istream<char>& stream);

	/// @brief �ж��ַ����Ƿ��������������
	/// @param dataLine ������
	/// @return Ϊ����ʱ������true�����򷵻�false
	bool _ifOddQuota(const BCLib::CString& dataLine);
	/// @brief �ж��Ƿ������������ſ�ʼ
	/// @param dataCell ���ݸ�
	/// @return Ϊ����ʱ������true�����򷵻�false
	bool _ifOddStartQuota(const BCLib::CString& dataCell);
	/// @brief �ж��Ƿ������������Ž�β
	/// @param dataCell ���ݸ�
	/// @return Ϊ����ʱ������true�����򷵻�false
	bool _ifOddEndQuota(const BCLib::CString& dataCell);
	/// @brief �����µ�������
	/// @param newDataLine ��������
	void _addNewDataLine(const BCLib::CString& newDataLine);
	/// @brief ȥ�����ӵ���β���ţ���˫���ű�ɵ�����
	/// @param fileCellData ���ݸ�
	/// @return ��ɵ����ŵ�����
	BCLib::CString _getHandleData(const BCLib::CString& fileCellData);

private:
	CRowList m_rowList;		// ������CSV�ļ���ÿһ��
	BCLib::CString m_fileName;

	static BCLib::CString ms_seperator;
	static BCLib::CString ms_quota;
	static BCLib::CString ms_doubleQuota;
};
}//Utility
}//BCLib

#endif//__SHLIB_UTILITY_CSVREADER_H__
