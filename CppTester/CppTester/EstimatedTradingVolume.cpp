
//-------依成交量分佈情況而設計的預估量演算法-------
//https://www.xq.com.tw/xstrader/%E4%BE%9D%E6%88%90%E4%BA%A4%E9%87%8F%E5%88%86%E4%BD%88%E6%83%85%E6%B3%81%E8%80%8C%E8%A8%AD%E8%A8%88%E7%9A%84%E9%A0%90%E4%BC%B0%E9%87%8F%E6%BC%94%E7%AE%97%E6%B3%95/

#include <cmath>
#include <algorithm>
#include <vector>
#include <iostream>

using namespace std;

const int BARPERDAY = 270; //(分K，270分鐘)

double Estimated_Trading_Volume(int length){
    vector<double> arr_minvolume(length * BARPERDAY, 0); // 每日每分鐘累計成交量
    vector<double> arr_minvolume_percent(BARPERDAY, 0); // 每分鐘累計成交量比例
    vector<double> arr_avg_minvolume(BARPERDAY, 0); // 每分鐘累計成交量


    cout<<arr_minvolume.size();






    return arr_minvolume.size();

}