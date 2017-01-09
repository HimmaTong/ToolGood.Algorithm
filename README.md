ToolGood.Algorithm
===================
ToolGood.Algorithm֧��`��������`��`Excel����`����֧��`�Զ������`��

## ��������
``` csharp
    AlgorithmEngine engine = new AlgorithmEngine();
    double t=0.0;
    if (engine.Parse("1+2")) {
        t = (double)engine.Evaluate();
    }
    var c = engine.TryEvaluate("2+3", 0);
```
֧�ֳ���`pi`,`e`,`true`,`false`

## �Զ������
``` csharp
    //����Բ����Ϣ
    public class Cylinder : AlgorithmEngine
    {
        private int _radius;
        private int _height;
        public Cylinder(int radius, int height)
        {
            _radius = radius;
            _height = height;
        }

        protected override Operand GetParameter(Operand curOpd)
        {
            if (curOpd.Parameter == "[�뾶]") {
                return new Operand(OperandType.NUMBER, _radius);
            }
            if (curOpd.Parameter == "[ֱ��]") {
                return new Operand(OperandType.NUMBER, _radius * 2);
            }
            if (curOpd.Parameter == "[��]") {
                return new Operand(OperandType.NUMBER, _height);
            }
            return base.GetParameter(curOpd);
        }
    }
    //���÷���
    Cylinder c = new Cylinder(3, 10);
    c.TryEvaluate("[�뾶]*[�뾶]*pi()", 0.0);      //Բ�����
    c.TryEvaluate("[ֱ��]*pi()", 0.0);            //Բ�ĳ�
    c.TryEvaluate("[�뾶]*[�뾶]*pi()*[��]", 0.0); //Բ�����
```


## Excel����
������`�߼�����`��`��ѧ�����Ǻ���`��`�ı�����`��`ͳ�ƺ���`��`������ʱ�亯��`

#### �߼�����
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>IF</td>
        <td>ִ�����ֵ�жϣ������߼���������ֵ�����ز�ͬ�����</td>
        <td>if(1=1,1,2) >>1</td>
    </tr>
    <tr>
        <td>IFERROR</td>
        <td>�����ʽ����������򷵻���ָ����ֵ�����򷵻ع�ʽ�����</td>
        <td>iferror(1/0,1,2) >>1</td>
    </tr>
    <tr>
        <td>IFNUMBER</td>
        <td>ָ��Ҫִ�е��߼����</td>
        <td>ifnumber(4,1,2) >>1</td>
    </tr>
    <tr>
        <td>IFTEXT</td>
        <td>ָ��Ҫִ�е��߼����</td>
        <td>iftext('a',1,2) >>1</td>
    </tr>
    <tr>
        <td>ISNUMBER</td>
        <td>�ж��Ƿ�����</td>
        <td>ISNUMBER(1) >>true</td>
    </tr>
    <tr>
        <td>ISTEXT</td>
        <td>�ж��Ƿ�����</td>
        <td>istext('1') >>true </td>
    </tr>
    <tr>
        <td>AND</td>
        <td>������в�����ΪTRUE���򷵻�TRUE</td>
        <td>and(1,2=2) >>true</td>
    </tr>
    <tr>
        <td>OR</td>
        <td>�����һ����ΪTRUE���򷵻�TRUE</td>
        <td>or(1,2=3) >>true</td>
    </tr>
    <tr>
        <td>NOT</td>
        <td>�Բ������߼�ֵ��</td>
        <td>NOT(true()) >>false</td>
    </tr>
    <tr>
        <td>TRUE</td>
        <td>�����߼�ֵTRUE</td>
        <td>true() >>true</td>
    </tr>
    <tr>
        <td>FALSE</td>
        <td>�����߼�ֵFALSE</td>
        <td>false() >>false</td>
    </tr>
</table>

#### ��ѧ�����Ǻ���
<table>
    <tr><td>����</td><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td rowspan="12">������ѧ</td>
        <td>PI</td><td>���� PI ֵ</td>
        <td>pi() >>3.141592654</td>
    </tr>
    <tr>
        <td>abs</td><td>abs(����)<br>�������ֵľ���ֵ</td>
        <td>abs(-1) >>1</td>
    </tr>
    <tr>
        <td>QUOTIENT</td><td>quotient(����,������)<br>�����̵��������֣��ú�������������̵�С�����֡�</td>
        <td>QUOTIENT(7,3) >>2</td>
    </tr>
    <tr>
        <td>mod</td><td>mod(����,������)<br>�����������������</td>
        <td>MOD(7,3) >>1</td>
    </tr>
    <tr>
        <td>SIGN</td><td>sign(����)<br>�������ֵķ��š�������Ϊ����ʱ���� 1��Ϊ��ʱ���� 0��Ϊ����ʱ���� -1��</td>
        <td>SIGN(-9) >>-1</td>
    </tr>
   <tr>
        <td>SQRT</td><td>sqrt(����)<br>������ƽ����</td>
        <td>SQRT(9) >>3</td>
    </tr>
    <tr>
        <td>TRUNC</td><td>trunc(����)<br>�����ֽ�βȡ��</td>
        <td>TRUNC(9.222) >>9  TRUNC(-9.222) >>-9 </td>
    </tr>
    <tr>
        <td>int</td><td>int(����)<br>�������������뵽��ӽ���������</td>
        <td>int(9.222) >>9   int(-9.222) >>-10</td>
    </tr>
    <tr>
        <td>gcd</td><td>gcd(����1,����2,...)<br>�������Լ��</td>
        <td>GCD(3,5,7) >>1</td>
    </tr>
    <tr>
        <td>LCM</td><td>lcm(����1,����2,...)<br>����������������С������</td>
        <td>LCM(3,5,7) >>105</td>
    </tr>
    <tr>
        <td>combin</td><td>combin(����,������)<br>����Ӹ�����Ŀ�Ķ��󼯺�����ȡ���ɶ���������</td>
        <td>combin(10,2) >>45</td>
    </tr>
    <tr>
        <td>PERMUT</td><td>permut(����,������)<br>���شӸ�����Ŀ�Ķ��󼯺���ѡȡ�����ɶ����������</td>
        <td>PERMUT(10,2) >>990</td>
    </tr>
    <tr>
    <td rowspan="15">���Ǻ���</td>
        <td>degrees</td><td>������ת��Ϊ��</td>
        <td>degrees(pi()) >>180</td>
    </tr>
    <tr>
        <td>RADIANS</td><td>����ת��Ϊ����</td>
        <td>RADIANS(180) >>3.141592654</td>
    </tr>
    <tr>
        <td>cos</td><td>�������ֵ�����ֵ</td>
        <td>cos(1) >>0.54030230586813977</td>
    </tr>
    <tr>
        <td>cosh</td><td>�������ֵ�˫������ֵ</td>
        <td>cosh(1) >>1.5430806348152437</td>
    </tr>
    <tr>
        <td>SIN</td><td>���ظ����Ƕȵ�����ֵ</td>
        <td>sin(1) >>0.8414709848078965</td>
    </tr>
    <tr>
        <td>SINH</td><td>�������ֵ�˫������ֵ</td>
        <td>sinh(1) >>1.1752011936438014</td>
    </tr>
    <tr>
        <td>TAN</td><td>�������ֵ�����ֵ</td>
        <td>tan(1) >>1.5574077246549023</td>
    </tr>
    <tr>
        <td>TANH</td><td>�������ֵ�˫������ֵ</td>
        <td>tanh(1) >>0.76159415595576485</td>
    </tr>
    <tr>
        <td>acos</td><td>�������ֵķ�����ֵ</td>
        <td>acos(0.5) >>1.0471975511965979</td>
    </tr>
    <tr>
        <td>acosh</td><td>�������ֵķ�˫������ֵ</td>
        <td>acosh(1.5) >>0.96242365011920694</td>
    </tr>
    <tr>
        <td>asin</td><td>�������ֵķ�����ֵ</td>
        <td>asin(0.5) >>0.52359877559829893</td>
    </tr>
    <tr>
        <td>asinh</td><td>�������ֵķ�˫������ֵ��</td>
        <td>asinh(1.5) >>1.1947632172871094</td>
    </tr>
    <tr>
        <td>atan</td><td>�������ֵķ�����ֵ</td>
        <td>atan(1) >>0.78539816339744828</td>
    </tr>
   <tr>
        <td>atanh</td><td>���ز����ķ�˫������ֵ</td>
        <td>atanh(1) >>0.54930614433405489</td>
    </tr>
    <tr>
        <td>atan2</td><td>��X��Y���귵�ط�����</td>
        <td>atan2(1,2) >>1.1071487177940904</td>
    </tr>
    <tr>
        <td rowspan="8">��������</td>
        <td>ROUND</td><td>����ĳ�����ְ�ָ��λ��ȡ��������֡�</td>
        <td>ROUND(4.333,2) >>4.33</td>
    </tr>
    <tr>
        <td>ROUNDDOWN</td><td>������ֵ�����£�����ֵ��С�ķ����������֡�</td>
        <td>ROUNDDOWN(4.333,2) >>4.33</td>
    </tr>
    <tr>
        <td>ROUNDUP</td><td>Զ����ֵ�����ϣ�����ֵ�����ķ����������֡�</td>
        <td>ROUNDUP(4.333,2) >>4.34</td>
    </tr>
    <tr>
        <td>CEILING</td><td>�������루�ؾ���ֵ����ķ���Ϊ��ӽ��� ������� �ı�����</td>
        <td>CEILING(4.333,0.1) >>4.4</td>
    </tr>
    <tr>
        <td>floor</td><td>�������룬ʹ�������ӽ��� Significance �ı�����</td>
        <td>FLOOR(4.333,0.1) >>4.3</td>
    </tr>
    <tr>
        <td>even</td><td>�����ؾ���ֵ������ȡ������ӽ���ż����</td>
        <td>EVEN(3) >>4</td>
    </tr>
    <tr>
        <td>ODD</td><td>��������������Ϊ��ӽ�����������</td>
        <td>ODD(3.1) >>5</td>
    </tr>
    <tr>
        <td>MROUND</td><td>����һ�����뵽���豶��������</td>
        <td>MROUND(13,5) >>15</td>
    </tr>
    <tr>
        <td rowspan="2">�����</td>
        <td>RAND</td><td>���� 0 �� 1 ֮�������� </td>
        <td>RAND() >>0.2</td>
    </tr>
    <tr>
        <td>RANDBETWEEN</td><td>���ش��ڵ���ָ������Сֵ��С��ָ�����ֵ֮���һ�����������</td>
        <td>RANDBETWEEN(2,44) >>9</td>
    </tr>
    <tr>
        <td rowspan="11">��/����/�׳�</td>
        <td>fact</td><td>�������Ľ׳ˣ�һ�����Ľ׳˵��� 1*2*3*��* ������</td>
        <td>FACT(3) >>6</td>
    </tr>
    <tr>
        <td>factdouble</td><td>�������ֵ�˫���׳�</td>
        <td>FACTDOUBLE(10) >>3840</td>
    </tr>
    <tr>
        <td>POWER</td><td>�������ĳ��ݽ��</td>
        <td>POWER(10,2) >>100</td>
    </tr>
    <tr>
        <td>exp</td><td>����e��ָ��������</td>
        <td>exp(2) >>7.389056099</td>
    </tr>
    <tr>
        <td>ln</td><td>�������ֵ���Ȼ����</td>
        <td>LN(4) >>1.386294361</td>
    </tr>
    <tr>
        <td>log</td><td>�������ֵĳ��ö���</td>
        <td>LOG(100,10) >>2</td>
    </tr>
    <tr>
        <td>LOG10</td><td>�������ֵ�10����</td>
        <td>LOG10(100) >>2</td>
    </tr>
    <tr>
        <td>MULTINOMIAL</td><td>���ز����͵Ľ׳���������׳˳˻��ı�ֵ</td>
        <td>MULTINOMIAL(1,2,3) >>60</td>
    </tr>
    <tr>
        <td>PRODUCT</td><td>�������Բ�����ʽ������������ˣ������س˻�ֵ��</td>
        <td>PRODUCT(1,2,3,4) >>24</td>
    </tr>
    <tr>
        <td>SQRTPI</td><td>����ĳ���� PI �ĳ˻���ƽ����</td>
        <td>SQRTPI(3) >>3.069980124</td>
    </tr>
    <tr>
        <td>SUMSQ</td><td>���ز�����ƽ����</td>
        <td>SUMSQ(1,2) >>5</td>
    </tr>
</table>

#### �ı�����
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>ASC</td><td>���ַ����ڵ�ȫ��Ӣ����ĸ����Ϊ����ַ�</td>
        <td>asc('������£ã�����') >>abcABC123</td>
    </tr>
    <tr>
        <td>JIS / WIDECHAR</td><td>���ַ����еİ��Ӣ���ַ�����Ϊȫ���ַ�</td>
        <td>jis('abcABC123') >>������£ã�����</td>
    </tr>
    <tr>
        <td>CHAR</td><td>�����ɴ�������ָ�����ַ�</td>
        <td>char(49) >>1</td>
    </tr>
    <tr>
        <td>CLEAN</td><td>ɾ���ı������д�ӡ�������ַ�</td>
        <td>clean('\r112\t') >>112</td>
    </tr>
    <tr>
        <td>CODE</td><td>�����ı��ַ����е�һ���ַ������ִ���</td>
        <td>CODE("1") >>49</td>
    </tr>
    <tr>
        <td>CONCATENATE</td><td>�������ı���ϲ���һ���ı�����</td>
        <td>CONCATENATE('tt','11') >>tt11</td>
    </tr>
    <tr>
        <td>EXACT</td><td>��������ı�ֵ�Ƿ���ȫ��ͬ</td>
        <td>EXACT("11","22") >>false</td>
    </tr>
    <tr>
        <td>FIND</td><td>��һ�ı�ֵ�ڲ�����һ�ı�ֵ�����ִ�Сд�� </td>
        <td>FIND("11","12221122") >>5</td>
    </tr>
    <tr>
        <td>FIXED</td><td>����������Ϊ���й̶�С��λ���ı���ʽ</td>
        <td>FIXED(4567.89,1) >>4,567.9</td>
    </tr>
    <tr>
        <td>LEFT</td><td>�����ı�ֵ����ߵ��ַ�</td>
        <td>LEFT('123222',3) >>123</td>
    </tr>
    <tr>
        <td>LEN</td><td>�����ı��ַ����е��ַ�����</td>
        <td>LEN('123222') >>6</td>
    </tr>
    <tr>
        <td>LOWER</td><td>���ı�ת��ΪСд��ʽ</td>
        <td>LOWER('ABC') >>abc</td>
    </tr>
    <tr>
        <td>MID</td><td>���ı��ַ����е�ָ��λ���𷵻��ض��������ַ�</td>
        <td>MID('ABCDEF',2,3) >>BCD</td>
    </tr>
    <tr>
        <td>PROPER</td><td>���ı�ֵ��ÿһ�����ʵ�����ĸ����Ϊ��д</td>
        <td>PROPER('abc abc') >>Abc Abc</td>
    </tr>
    <tr>
        <td>REPLACE</td><td>�滻�ı��ڵ��ַ�</td>
        <td>REPLACE("abccd",2,3,"2") >>a2d</td>
    </tr>
    <tr>
        <td>REPT</td><td>�����������ظ��ı�</td>
        <td>REPT("q",3) >>qqq</td>
    </tr>
    <tr>
        <td>RIGHT</td><td>�����ı�ֵ���ұߵ��ַ�</td>
        <td>RIGHT("123q",3) >>23q</td>
    </tr>
    <tr>
        <td>RMB</td><td>������ת��Ϊ��д�����ı�</td>
        <td>rmb(12.3) >>Ҽʰ��Ԫ����</td>
    </tr>
    <tr>
        <td>SEARCH</td><td>��һ�ı�ֵ�в�����һ�ı�ֵ�������ִ�Сд��</td>
        <td>SEARCH("aa","abbAaddd") >>4</td>
    </tr>
    <tr>
        <td>SUBSTITUTE</td><td>���ı��ַ����������ı��滻���ı�</td>
        <td>SUBSTITUTE("ababcc","ab","12") >>1212cc</td>
    </tr>
    <tr>
        <td>T</td><td>������ת��Ϊ�ı�</td>
        <td>T('123') >>123</td>
    </tr>
    <tr>
        <td>TEXT</td><td>�������ֵĸ�ʽ��������ת��Ϊ�ı�</td>
        <td>TEXT(123,"0.00") >>123.00</td>
    </tr>
    <tr>
        <td>TRIM</td><td>ɾ���ı��еĿո�</td>
        <td>TRIM(" 123 123 ")>>123 123</td>
    </tr>
    <tr>
        <td>UPPER</td><td>���ı�ת��Ϊ��д��ʽ</td>
        <td>UPPER("abc") >>ABC</td>
    </tr>
    <tr>
        <td>VALUE</td><td>���ı�����ת��Ϊ����</td>
        <td>VALUE("123") >>123</td>
    </tr>
</table>

#### ������ʱ�亯��
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>DATEVALUE</td><td>���ı���ʽ������ת��Ϊ���к�</td>
        <td>DATEVALUE("2017-01-02") >>2017-01-02</td>
    </tr>
    <tr>
        <td>TIMEVALUE</td><td>���ı���ʽ��ʱ��ת��Ϊ���к�</td>
        <td>TIMEVALUE("12:12:12") >>12:12:12</td>
    </tr>
    <tr>
        <td>DATE</td><td>�����ض����ڵ����к�</td>
        <td>DATE(2016,1,1) >>2016-01-01</td>
    </tr>
    <tr>
        <td>TIME</td><td>�����ض�ʱ������к�</td>
        <td>TIME(12,13,14) >>12:13:14</td>
    </tr>
    <tr>
        <td>NOW</td><td>���ص�ǰ���ں�ʱ������к�</td>
        <td>NOW() >>2017-01-07 11:00:00</td>
    </tr>
    <tr>
        <td>TODAY</td><td>���ؽ������ڵ����к�</td>
        <td>TODAY() >>2017-01-07</td>
    </tr>
    <tr>
        <td>YEAR</td><td>�����к�ת��Ϊ��</td>
        <td>YEAR(NOW()) >>2017</td>
    </tr>
    <tr>
        <td>MONTH</td><td>�����к�ת��Ϊ��</td>
        <td>MONTH(NOW()) >>1</td>
    </tr>
    <tr>
        <td>DAY</td><td>�����к�ת��Ϊ�·��е���</td>
        <td>DAY(NOW()) >>7</td>
    </tr>
    <tr>
        <td>HOUR</td><td>�����к�ת��ΪСʱ</td>
        <td>HOUR(NOW()) >>11</td>
    </tr>
    <tr>
        <td>MINUTE</td><td>�����к�ת��Ϊ����</td>
        <td>MINUTE(NOW()) >>12</td>
    </tr>
    <tr>
        <td>SECOND</td><td>�����к�ת��Ϊ��</td>
        <td>SECOND(NOW()) >>34</td>
    </tr>
    <tr>
        <td>WEEKDAY</td><td>�����к�ת��Ϊ���ڼ�</td>
        <td>WEEKDAY(date(2017,1,7)) >>7</td>
    </tr>
    <tr>
        <td>DATEDIF</td><td>������������֮����������</td>
        <td>DATEDIF("1975-1-30","2017-1-7","Y") >>41</td>
    </tr>
    <tr>
        <td>DAYS360</td><td>��һ�� 360 ��Ϊ��׼�����������ڼ������</td>
        <td>DAYS360('1975-1-30','2017-1-7') >>15097</td>
    </tr>
    <tr>
        <td>EDATE</td><td>�������ڱ�ʾ��ʼ����֮ǰ��֮�����������ڵ����к�</td>
        <td>EDATE("2012-1-31",32) >>2014-09-30</td>
    </tr>
    <tr>
        <td>EOMONTH</td><td>����ָ������֮ǰ��֮����·ݵ����һ������к�</td>
        <td>EOMONTH("2012-2-1",32) >>2014-10-31</td>
    </tr>
    <tr>
        <td>NETWORKDAYS</td><td>������������֮���ȫ����������</td>
        <td>NETWORKDAYS("2012-1-1","2013-1-1") >>262</td>
    </tr>
    <tr>
        <td>WORKDAY</td><td>����ָ�������ɸ�������֮ǰ��֮������ڵ����к�</td>
        <td>WORKDAY("2012-1-2",145) >>2012-07-23</td>
    </tr>
    <tr>
        <td>WEEKNUM</td><td>�����к�ת��Ϊһ������Ӧ������</td>
        <td>WEEKNUM("2016-1-3") >>2</td>
    </tr>
</table>

#### ͳ�ƺ���
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>MAX</td><td>���ز����б��е����ֵ</td>
        <td>max(1,2,3,4,2,2,1,4) >>4</td>
    </tr>
    <tr>
        <td>MEDIAN</td><td>���ظ������ֵ���ֵ</td>
        <td>MEDIAN(1,2,3,4,2,2,1,4) >>2</td>
    </tr>
    <tr>
        <td>MIN</td><td>���ز����б��е���Сֵ</td>
        <td>MIN(1,2,3,4,2,2,1,4) >>1</td>
    </tr>
    <tr>
        <td>QUARTILE</td><td>�������ݼ����ķ�λ��</td>
        <td>QUARTILE({1,2,3,4,2,2,1,4},0) >>1</td>
    </tr>
    <tr>
        <td>MODE</td><td>�������ݼ��г�������ֵ��ĸ���</td>
        <td>MODE(1,2,3,4,2,2,1,4) >>2</td>
    </tr>
    <tr>
        <td>LARGE</td><td>�������ݼ��е� k �����ֵ</td>
        <td>LARGE({1,2,3,4,2,2,1,4},3) >>3</td>
    </tr>
    <tr>
        <td>SMALL</td><td>�������ݼ��е� k ����Сֵ</td>
        <td>SMALL({1,2,3,4,2,2,1,4},3) >>2</td>
    </tr>
    <tr>
        <td>PERCENTILE</td><td>���������еĵ� k ���ٷ�λֵ</td>
        <td>PERCENTILE({1,2,3,4,2,2,1,4}��0.4) >>2</td>
    </tr>
    <tr>
        <td>PERCENTRANK</td><td>�������ݼ���ֵ�İٷֱ���λ</td>
        <td>PERCENTRANK({1,2,3,4,2,2,1,4}��3) >>0.714</td>
    </tr>
    <tr>
        <td>AVERAGE</td><td>���ز�����ƽ��ֵ</td>
        <td>AVERAGE(1,2,3,4,2,2,1,4) >>2.375</td>
    </tr>
    <tr>
        <td>AVERAGEIF</td><td>���ز�����ƽ��ֵ</td>
        <td>AVERAGEIF({1,2,3,4,2,2,1,4},'>1') >>2.833333333</td>
    </tr>
    <tr>
        <td>GEOMEAN</td><td>�����������������ļ���ƽ��ֵ</td>
        <td>GEOMEAN(1,2,3,4) >>2.213363839</td>
    </tr>
    <tr>
        <td>HARMEAN</td><td>�������ݼ��ϵĵ���ƽ��ֵ</td>
        <td>HARMEAN(1,2,3,4) >>1.92</td>
    </tr>
    <tr>
        <td>COUNT</td><td>��������б������ֵĸ���</td>
        <td>COUNT(1,2,3,4,2,2,1,4) >>8</td>
    </tr>
    <tr>
        <td>COUNTIF</td><td>��������б������ֵĸ���</td>
        <td>COUNTIF({1,2,3,4,2,2,1,4},'>1') >>6</td>
    </tr>
    <tr>
        <td>SUM</td><td>������������֮�͡�</td>
        <td>SUM(1,2,3,4) >>10</td>
    </tr>
    <tr>
        <td>SUMIF</td><td>������������֮��</td>
        <td>SUMIF({1,2,3,4,2,2,1,4},'>1') >>17</td>
    </tr>
    <tr>
        <td>AVEDEV</td><td>�������ݵ�����ƽ��ֵ�ľ���ƫ���ƽ��ֵ</td>
        <td>AVEDEV(1,2,3,4,2,2,1,4) >>0.96875</td>
    </tr>
    <tr>
        <td>STDEV</td><td>�������������׼ƫ��</td>
        <td>STDEV(1,2,3,4,2,2,1,4) >>1.1877349391654208</td>
    </tr>
    <tr>
        <td>STDEVP</td><td>�������������������ı�׼ƫ��</td>
        <td>STDEVP(1,2,3,4,2,2,1,4) >>1.1110243021644486</td>
    </tr>
    <tr>
        <td>DEVSQ</td><td>����ƫ���ƽ����</td>
        <td>DEVSQ(1,2,3,4,2,2,1,4) >>9.875</td>
    </tr>
    <tr>
        <td>VAR</td><td>�����������㷽��</td>
        <td>VAR(1,2,3,4,2,2,1,4) >>1.4107142857142858</td>
    </tr>
    <tr>
        <td>VARP</td><td>������������������㷽��</td>
        <td>VARP(1,2,3,4,2,2,1,4) >>1.234375</td>
    </tr>
    <tr>
        <td>NormSDist</td><td>���ر�׼��̬�ۻ��ֲ��������÷ֲ���ƽ��ֵΪ 0����׼ƫ��Ϊ 1��</td>
        <td>NORMSDIST(1) >>0.841344746</td>
    </tr>
    <tr>
        <td>NORMDIST</td><td>������̬�ۻ��ֲ�</td>
        <td>NORMDIST(3,8,4,1) >>0.105649774</td>
    </tr>
    <tr>
        <td>NORMINV</td><td>���ط���̬�ۻ��ֲ�</td>
        <td>NORMINV(0.8,8,3) >>10.5248637</td>
    </tr>
    <tr>
        <td>NORMSINV</td><td>���ط���׼��̬�ۻ��ֲ�</td>
        <td>NORMSINV(0.3) >>-0.524400513</td>
    </tr>
    <tr>
        <td>BETADIST</td><td>���� Beta �ۻ��ֲ���������֧�����½�</td>
        <td>BETADIST(0.5,11,22) >>0.97494877</td>
    </tr>
    <tr>
        <td>BETAINV</td><td>����ָ�� Beta �ֲ����ۻ��ֲ������ķ�����,��֧�����½�</td>
        <td>BETAINV(0.5,23,45) >>0.336640759</td>
    </tr>
    <tr>
        <td>BINOMDIST</td><td>����һԪ����ʽ�ֲ�����</td>
        <td>BINOMDIST(12,45,0.5,0) >>0.000817409</td>
    </tr>
    <tr>
        <td>EXPONDIST</td><td>����ָ���ֲ�</td>
        <td>EXPONDIST(3,1,0) >>0.049787068</td>
    </tr>
    <tr>
        <td>FDIST</td><td>���� F ���ʷֲ�</td>
        <td>FDIST(0.4,2,3) >>0.701465776</td>
    </tr>
    <tr>
        <td>FINV</td><td>���� F ���ʷֲ��ķ�����</td>
        <td>FINV(0.7,2,3) >>0.402651432</td>
    </tr>
    <tr>
        <td>FISHER</td><td>���ص� x �� Fisher �任���ñ任����һ����̬�ֲ�����ƫб�ĺ���</td>
        <td>FISHER(0.68) >>0.8291140383</td>
    </tr>
    <tr>
        <td>FISHERINV</td><td>���� Fisher �任�ķ�����ֵ��</td>
        <td>FISHERINV(0.6) >>0.537049567</td>
    </tr>
    <tr>
        <td>GAMMADIST</td><td>���� �� �ֲ�</td>
        <td>GAMMADIST(0.5,3,4,0) >>0.001723627</td>
    </tr>
    <tr>
        <td>GAMMAINV</td><td>���� �� �ۻ��ֲ������ķ�����</td>
        <td>GAMMAINV(0.2,3,4) >>6.140176811</td>
    </tr>
    <tr>
        <td>GAMMALN</td><td>���� �� �ۻ��ֲ������ķ�����</td>
        <td>GAMMALN(4) >>1.791759469</td>
    </tr>
    <tr>
        <td>HYPGEOMDIST</td><td>���س����ηֲ�</td>
        <td>HYPGEOMDIST(23,45,45,100) >>0.08715016</td>
    </tr>
    <tr>
        <td>LOGINV</td><td>���� x �Ķ����ۻ��ֲ������ķ�����</td>
        <td>LOGINV(0.1,45,33) >>15.01122624</td>
    </tr>
    <tr>
        <td>LognormDist</td><td>���ط�������̬�ֲ�</td>
        <td>LOGNORMDIST(15,23,45) >>0.326019201</td>
    </tr>
    <tr>
        <td>NEGBINOMDIST</td><td>���ظ�����ʽ�ֲ�</td>
        <td>NEGBINOMDIST(23,45,0.7) >>0.053463314</td>
    </tr>
    <tr>
        <td>POISSON</td><td>���� Poisson �ֲ�</td>
        <td>POISSON(23,23,0) >>0.082884384</td>
    </tr>
    <tr>
        <td>TDIST</td><td>����ѧ���� t �ֲ�</td>
        <td>TDIST(1.2,24,1) >>0.120925677</td>
    </tr>
    <tr>
        <td>TINV</td><td>����ѧ���� t �ֲ��ķ��ֲ�</td>
        <td>TINV(0.12,23) >>1.614756561</td>
    </tr>
    <tr>
        <td>WEIBULL</td><td>���� Weibull �ֲ�</td>
        <td>WEIBULL(1,2,3,1) >>0.105160683</td>
    </tr>

</table>


