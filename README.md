ToolGood.Algorithm
===================

#### ��������
``` csharp
    AlgorithmEngine engine = new AlgorithmEngine();
    double t=0.0;
    if (engine.Parse("1+2")) {
        t = (double)engine.Evaluate();
    }
    var c = engine.TryEvaluate("2+3", 0);
```


#### ��Excel��ʽ
��ʽ��`����`��`��ѧ`��`�ַ���`��`ͳ��`��`����`

##### ���̹�ʽ
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>IF</td>
        <td>ָ��Ҫִ�е��߼����</td>
        <td>if(1=1,1,2) ->1</td>
    </tr>
    <tr>
        <td>IFERROR</td>
        <td>ָ��Ҫִ�е��߼����</td>
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

#### ��ѧ��ʽ
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td>abs</td><td>�������ֵľ���ֵ</td>
        <td>abs(-1)=1</td>
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
        <td>ceiling</td><td>����������,ȡ�컨��ֵ</td>
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
        <td>degrees</td><td>������ת��Ϊ��</td>
        <td></td>
    </tr>
    <tr>
        <td>even</td><td>��������������Ϊ��ӽ���ż������</td>
        <td></td>
    </tr>
    <tr>
        <td>exp</td><td>����e��ָ��������</td>
        <td></td>
    </tr>
    <tr>
        <td>fact</td><td>�������ֵĽ׳�</td>
        <td></td>
    </tr>
    <tr>
        <td>factdouble</td><td>�������ֵ�˫���׳�</td>
        <td></td>
    </tr>
    <tr>
        <td>floor</td><td>����������Ϊ��ӽ���������ȡ�ذ�ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>gcd</td><td>�������Լ��</td>
        <td></td>
    </tr>
    <tr>
        <td>int</td><td></td>
        <td></td>
    </tr>
    <tr>
        <td>lgm</td><td>����������������С������</td>
        <td></td>
    </tr>
    <tr>
        <td>ln</td><td>�������ֵ���Ȼ����</td>
        <td></td>
    </tr>
    <tr>
        <td>log</td><td>�������ֵĳ��ö���</td>
        <td></td>
    </tr>
    <tr>
        <td>LOG10</td><td>�������ֵ�10����</td>
        <td></td>
    </tr>
    <tr>
        <td>MULTINOMIAL</td><td>���ز����͵Ľ׳���������׳˳˻��ı�ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>mod</td><td>�����������������</td>
        <td></td>
    </tr>
    <tr>
        <td>MROUND</td><td>����һ�����뵽���豶��������</td>
        <td></td>
    </tr>
    <tr>
        <td>ODD</td><td>��������������Ϊ��ӽ�����������</td>
        <td></td>
    </tr>
    <tr>
        <td>PI</td><td>���� PI ֵ</td>
        <td></td>
    </tr>
    <tr>
        <td>POWER</td><td>�������ĳ��ݽ��</td>
        <td></td>
    </tr>
    <tr>
        <td>PRODUCT</td><td>�������Բ�����ʽ�������������</td>
        <td></td>
    </tr>
    <tr>
        <td>QUOTIENT</td><td>�����̵��������֣��ú�������������̵�С�����֡�</td>
        <td></td>
    </tr>
    <tr>
        <td>RADIANS</td><td>����ת��Ϊ����</td>
        <td></td>
    </tr>
    <tr>
        <td>RAND</td><td>���� 0 �� 1 ֮�������� </td>
        <td></td>
    </tr>
    <tr>
        <td>RANDBETWEEN</td><td>����ָ������֮��������</td>
        <td></td>
    </tr>
    <tr>
        <td>ROUND</td><td>���������뵽ָ��λ��</td>
        <td></td>
    </tr>
    <tr>
        <td>ROUNDDOW</td><td>�����ֳ���ķ�������</td>
        <td></td>
    </tr>
    <tr>
        <td>ROUNDUP</td><td>������Զ����ķ�������</td>
        <td></td>
    </tr>

</table>


#### �ַ�����ʽ
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>


#### ͳ�ƹ�ʽ
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>

#### ���ڹ�ʽ
<table>
    <tr><td>��ʽ��</td><td>˵��</td><td>ʾ��</td></tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>
