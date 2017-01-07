ToolGood.Algorithm
===================

## ��������
``` csharp
    AlgorithmEngine engine = new AlgorithmEngine();
    double t=0.0;
    if (engine.Parse("1+2")) {
        t = (double)engine.Evaluate();
    }
    var c = engine.TryEvaluate("2+3", 0);
```


## ��Excel����
������`�߼�����`��`��ѧ�����Ǻ���`��`�ı�����`��`ͳ�ƺ���`��`������ʱ�亯��`

#### �߼�����
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>IF</td>
        <td>ִ�����ֵ�жϣ������߼���������ֵ�����ز�ͬ�����</td>
        <td>if(1=1,1,2) ->1</td>
    </tr>
    <tr>
        <td>IFERROR</td>
        <td>�����ʽ����������򷵻���ָ����ֵ�����򷵻ع�ʽ�����</td>
        <td>iferror(1/0,1,2) ->1</td>
    </tr>
    <tr>
        <td>IFNUMBER</td>
        <td>ָ��Ҫִ�е��߼����</td>
        <td>ifnumber(4,1,2) ->1</td>
    </tr>
    <tr>
        <td>IFTEXT</td>
        <td>ָ��Ҫִ�е��߼����</td>
        <td>iftext('a',1,2) ->1</td>
    </tr>
    <tr>
        <td>ISNUMBER</td>
        <td>�ж��Ƿ�����</td>
        <td>ISNUMBER(1) ->true</td>
    </tr>
    <tr>
        <td>ISTEXT</td>
        <td>�ж��Ƿ�����</td>
        <td>istext('1') ->true </td>
    </tr>
    <tr>
        <td>AND</td>
        <td>������в�����ΪTRUE���򷵻�TRUE</td>
        <td>and(1,2=2) ->true</td>
    </tr>
    <tr>
        <td>OR</td>
        <td>�����һ����ΪTRUE���򷵻�TRUE</td>
        <td>or(1,2=3) ->true</td>
    </tr>
    <tr>
        <td>NOT</td>
        <td>�Բ������߼�ֵ��</td>
        <td>NOT(true()) ->false</td>
    </tr>
    <tr>
        <td>TRUE</td>
        <td>�����߼�ֵTRUE</td>
        <td>true() ->true</td>
    </tr>
    <tr>
        <td>FALSE</td>
        <td>�����߼�ֵFALSE</td>
        <td>false() ->false</td>
    </tr>
</table>

#### ��ѧ�����Ǻ���
<table>
    <tr><td>����</td><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td rowspan="11">������ѧ</td>
        <td>PI</td><td>���� PI ֵ</td>
        <td>pi() ->3.141592654</td>
    </tr>
    <tr>
        <td>abs</td><td>�������ֵľ���ֵ</td>
        <td>abs(-1) ->1</td>
    </tr>
    <tr>
        <td>QUOTIENT</td><td>�����̵��������֣��ú�������������̵�С�����֡�</td>
        <td>QUOTIENT(7,3) ->2</td>
    </tr>
    <tr>
        <td>mod</td><td>�����������������</td>
        <td>MOD(7,3) ->1</td>
    </tr>
    <tr>
        <td>SIGN</td><td>�������ֵķ��š�������Ϊ����ʱ���� 1��Ϊ��ʱ���� 0��Ϊ����ʱ���� -1��</td>
        <td>SIGN(-9) ->-1</td>
    </tr>
   <tr>
        <td>SQRT</td><td>������ƽ����</td>
        <td>SQRT(9) ->3</td>
    </tr>
    <tr>
        <td>SUM</td><td>������������֮�͡�</td>
        <td>SUM(1,2,3,4) ->10</td>
    </tr>
    <tr>
        <td>TRUNC</td><td>�����ֽ�βȡ��</td>
        <td>TRUNC(9.222) ->9  TRUNC(-9.222) ->-9 </td>
    </tr>
    <tr>
        <td>int</td><td>�������������뵽��ӽ���������</td>
        <td>int(9.222) ->9   int(-9.222) ->-10</td>
    </tr>
    <tr>
        <td>gcd</td><td>�������Լ��</td>
        <td>GCD(3,5,7) ->1</td>
    </tr>
    <tr>
        <td>LCM</td><td>����������������С������</td>
        <td>LCM(3,5,7) ->105</td>
    </tr>
    <tr>
    <td rowspan="13">���Ǻ���</td>
        <td>degrees</td><td>������ת��Ϊ��</td>
        <td></td>
    </tr>
    <tr>
        <td>RADIANS</td><td>����ת��Ϊ����</td>
        <td></td>
    </tr>
    <tr>
        <td>cos</td><td>�������ֵ�����ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>cosh</td><td>�������ֵ�˫������ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>SIN</td><td>���ظ����Ƕȵ�����ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>SINH</td><td>�������ֵ�˫������ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>TAN</td><td>�������ֵ�����ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>TANH</td><td>�������ֵ�˫������ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>acos</td><td>�������ֵķ�����ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>acosh</td><td>�������ֵķ�˫������ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>asin</td><td>�������ֵķ�����ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>atan</td><td>�������ֵķ�����ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>atan2</td><td>��X��Y���귵�ط�����</td>
        <td></td>
    </tr>
    <tr>
        <td rowspan="8">��������</td>
        <td>ROUND</td><td>����ĳ�����ְ�ָ��λ��ȡ��������֡�</td>
        <td>ROUND(4.333,2) ->4.33</td>
    </tr>
    <tr>
        <td>ROUNDDOWN</td><td>������ֵ�����£�����ֵ��С�ķ����������֡�</td>
        <td>ROUNDDOWN(4.333,2) ->4.33</td>
    </tr>
    <tr>
        <td>ROUNDUP</td><td>Զ����ֵ�����ϣ�����ֵ�����ķ����������֡�</td>
        <td>ROUNDUP(4.333,2) ->4.34</td>
    </tr>
    <tr>
        <td>ceiling</td><td>�������루�ؾ���ֵ����ķ���Ϊ��ӽ��� ������� �ı�����</td>
        <td>CEILING(4.333,0.1) ->4.4</td>
    </tr>
    <tr>
        <td>floor</td><td>�������룬ʹ�������ӽ��� Significance �ı�����</td>
        <td>FLOOR(4.333,0.1) ->4.3</td>
    </tr>
    <tr>
        <td>even</td><td>�����ؾ���ֵ������ȡ������ӽ���ż����</td>
        <td>EVEN(3) ->4</td>
    </tr>
    <tr>
        <td>ODD</td><td>��������������Ϊ��ӽ�����������</td>
        <td>ODD(3.1) ->5</td>
    </tr>
    <tr>
        <td>MROUND</td><td>����һ�����뵽���豶��������</td>
        <td>MROUND(13,5) ->15</td>
    </tr>
    <tr>
        <td rowspan="2">�����</td>
        <td>RAND</td><td>���� 0 �� 1 ֮�������� </td>
        <td>RAND() ->0.2</td>
    </tr>
    <tr>
        <td>RANDBETWEEN</td><td>���ش��ڵ���ָ������Сֵ��С��ָ�����ֵ֮���һ�����������</td>
        <td>RANDBETWEEN(2,44) ->9</td>
    </tr>
    <tr>
        <td rowspan="11">��/����/�׳�</td>
        <td>fact</td><td>�������Ľ׳ˣ�һ�����Ľ׳˵��� 1*2*3*��* ������</td>
        <td>FACT(3) ->6</td>
    </tr>
    <tr>
        <td>factdouble</td><td>�������ֵ�˫���׳�</td>
        <td>FACTDOUBLE(10) ->3840</td>
    </tr>
    <tr>
        <td>POWER</td><td>�������ĳ��ݽ��</td>
        <td>POWER(10,2) ->100</td>
    </tr>
    <tr>
        <td>exp</td><td>����e��ָ��������</td>
        <td>exp(2) ->7.389056099</td>
    </tr>
    <tr>
        <td>ln</td><td>�������ֵ���Ȼ����</td>
        <td>LN(4) ->1.386294361</td>
    </tr>
    <tr>
        <td>log</td><td>�������ֵĳ��ö���</td>
        <td>LOG(100,10) ->2</td>
    </tr>
    <tr>
        <td>LOG10</td><td>�������ֵ�10����</td>
        <td>LOG10(100) ->2</td>
    </tr>
    <tr>
        <td>MULTINOMIAL</td><td>���ز����͵Ľ׳���������׳˳˻��ı�ֵ</td>
        <td>MULTINOMIAL(1,2,3) ->60</td>
    </tr>
    <tr>
        <td>PRODUCT</td><td>�������Բ�����ʽ������������ˣ������س˻�ֵ��</td>
        <td>PRODUCT(1,2,3,4) ->24</td>
    </tr>
    <tr>
        <td>SQRTPI</td><td>����ĳ���� PI �ĳ˻���ƽ����</td>
        <td>SQRTPI(3) ->3.069980124</td>
    </tr>
    <tr>
        <td>SUMSQ</td><td>���ز�����ƽ����</td>
        <td>SUMSQ(1,2) ->5</td>
    </tr>
</table>

#### �ı�����
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>ASC</td><td>���ַ����ڵ�ȫ��Ӣ����ĸ����Ϊ����ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>JIS</td><td>���ַ����еİ��Ӣ���ַ�����Ϊȫ���ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>CHAR</td><td>�����ɴ�������ָ�����ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>CLEAN</td><td>ɾ���ı������д�ӡ�������ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>CODE</td><td>�����ı��ַ����е�һ���ַ������ִ���</td>
        <td></td>
    </tr>
    <tr>
        <td>CONCATENATE</td><td>�������ı���ϲ���һ���ı�����</td>
        <td></td>
    </tr>
    <tr>
        <td>EXACT</td><td>��������ı�ֵ�Ƿ���ȫ��ͬ</td>
        <td></td>
    </tr>
    <tr>
        <td>FIND</td><td>��һ�ı�ֵ�ڲ�����һ�ı�ֵ�����ִ�Сд�� </td>
        <td></td>
    </tr>
    <tr>
        <td>FIXED</td><td>����������Ϊ���й̶�С��λ���ı���ʽ</td>
        <td></td>
    </tr>
    <tr>
        <td>LEFT</td><td>�����ı�ֵ����ߵ��ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>LEN</td><td>�����ı��ַ����е��ַ�����</td>
        <td></td>
    </tr>
    <tr>
        <td>LOWER</td><td>���ı�ת��ΪСд��ʽ</td>
        <td></td>
    </tr>
    <tr>
        <td>MID</td><td>���ı��ַ����е�ָ��λ���𷵻��ض��������ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>PROPER</td><td>���ı�ֵ��ÿһ�����ʵ�����ĸ����Ϊ��д</td>
        <td></td>
    </tr>
    <tr>
        <td>REPLACE</td><td>�滻�ı��ڵ��ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>REPT</td><td>�����������ظ��ı�</td>
        <td></td>
    </tr>
    <tr>
        <td>RIGHT</td><td>�����ı�ֵ���ұߵ��ַ�</td>
        <td></td>
    </tr>
    <tr>
        <td>RMB</td><td>������ת��Ϊ��д�����ı�</td>
        <td></td>
    </tr>
    <tr>
        <td>SEARCH</td><td>��һ�ı�ֵ�в�����һ�ı�ֵ�������ִ�Сд��</td>
        <td></td>
    </tr>
    <tr>
        <td>SUBSTITUTE</td><td>���ı��ַ����������ı��滻���ı�</td>
        <td></td>
    </tr>
    <tr>
        <td>T</td><td>������ת��Ϊ�ı�</td>
        <td></td>
    </tr>
    <tr>
        <td>TEXT</td><td>�������ֵĸ�ʽ��������ת��Ϊ�ı�</td>
        <td></td>
    </tr>
    <tr>
        <td>TRIM</td><td>ɾ���ı��еĿո�</td>
        <td></td>
    </tr>
    <tr>
        <td>UPPER</td><td>���ı�ת��Ϊ��д��ʽ</td>
        <td></td>
    </tr>
    <tr>
        <td>VALUE</td><td>���ı�����ת��Ϊ����</td>
        <td></td>
    </tr>
</table>

#### ������ʱ�亯��
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>DATEVALUE</td><td>���ı���ʽ������ת��Ϊ���к�</td>
        <td>DATEVALUE("2017-01-02") ->2017-01-02</td>
    </tr>
    <tr>
        <td>TIMEVALUE</td><td>���ı���ʽ��ʱ��ת��Ϊ���к�</td>
        <td>TIMEVALUE("12:12:12") ->12:12:12</td>
    </tr>
    <tr>
        <td>DATE</td><td>�����ض����ڵ����к�</td>
        <td>DATE(2016,1,1) ->2016-01-01</td>
    </tr>
    <tr>
        <td>TIME</td><td>�����ض�ʱ������к�</td>
        <td>TIME(12,13,14) ->12:13:14</td>
    </tr>
    <tr>
        <td>NOW</td><td>���ص�ǰ���ں�ʱ������к�</td>
        <td>NOW() ->2017-01-07 11:00:00</td>
    </tr>
    <tr>
        <td>TODAY</td><td>���ؽ������ڵ����к�</td>
        <td>TODAY() ->2017-01-07</td>
    </tr>
    <tr>
        <td>YEAR</td><td>�����к�ת��Ϊ��</td>
        <td>YEAR(NOW()) ->2017</td>
    </tr>
    <tr>
        <td>MONTH</td><td>�����к�ת��Ϊ��</td>
        <td>MONTH(NOW()) ->1</td>
    </tr>
    <tr>
        <td>DAY</td><td>�����к�ת��Ϊ�·��е���</td>
        <td>DAY(NOW()) ->7</td>
    </tr>
    <tr>
        <td>HOUR</td><td>�����к�ת��ΪСʱ</td>
        <td>HOUR(NOW()) ->11</td>
    </tr>
    <tr>
        <td>MINUTE</td><td>�����к�ת��Ϊ����</td>
        <td>MINUTE(NOW()) ->12</td>
    </tr>
    <tr>
        <td>SECOND</td><td>�����к�ת��Ϊ��</td>
        <td>SECOND(NOW()) ->34</td>
    </tr>
    <tr>
        <td>WEEKDAY</td><td>�����к�ת��Ϊ���ڼ�</td>
        <td>WEEKDAY(date(2017,1,7)) ->7</td>
    </tr>
    <tr>
        <td>DATEDIF</td><td>������������֮����������</td>
        <td>DATEDIF("1975-1-30","2017-1-7","Y") ->41</td>
    </tr>
    <tr>
        <td>DAYS360</td><td>��һ�� 360 ��Ϊ��׼�����������ڼ������</td>
        <td>DAYS360('1975-1-30','2017-1-7') ->15097</td>
    </tr>
    <tr>
        <td>EDATE</td><td>�������ڱ�ʾ��ʼ����֮ǰ��֮�����������ڵ����к�</td>
        <td>EDATE("2012-1-31",32) ->2014-09-30</td>
    </tr>
    <tr>
        <td>EOMONTH</td><td>����ָ������֮ǰ��֮����·ݵ����һ������к�</td>
        <td>EOMONTH("2012-2-1",32) ->2014-10-31</td>
    </tr>
    <tr>
        <td>NETWORKDAYS</td><td>������������֮���ȫ����������</td>
        <td>NETWORKDAYS("2012-1-1","2013-1-1") ->262</td>
    </tr>
    <tr>
        <td>WORKDAY</td><td>����ָ�������ɸ�������֮ǰ��֮������ڵ����к�</td>
        <td>WORKDAY("2012-1-2",145) ->2012-07-23</td>
    </tr>
    <tr>
        <td>WEEKNUM</td><td>�����к�ת��Ϊһ������Ӧ������</td>
        <td>WEEKNUM("2016-1-3") ->2</td>
    </tr>
</table>

#### ͳ�ƺ���
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>


