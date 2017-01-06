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
��ʽ��`����`��`��ѧ`��`�ַ���`

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
| ��ʽ��               | ˵��                 | ʾ��                 |
|: ------------------ :|: ------------------ :|: ------------------ :|
| abs                  | �������ֵľ���ֵ     | abs(-1)=1            |
| acos                 | �������ֵķ�����ֵ   | acos(0.5)=1 |
| acosh                | �������ֵķ�˫������ֵ     | abs(-1)=1            |
| asin                 | �������ֵķ�����ֵ     | abs(-1)=1            |
| atan                 | �������ֵķ�����ֵ     | abs(-1)=1            |
| atan2                | ��X��Y���귵�ط����� | abs(-1)=1            |
| ceiling              | ����������Ϊ��ӽ�������������ӽ�����Ч���ֵı���     | abs(-1)=1            |
| cos                  | �������ֵ�����ֵ     | abs(-1)=1            |
| cosh                 | �������ֵ�˫������ֵ     | abs(-1)=1            |
| degrees              | ������ת��Ϊ��     | abs(-1)=1            |
| even                 | ��������������Ϊ��ӽ���ż������     | abs(-1)=1            |
| exp                  | ����e��ָ��������     | abs(-1)=1            |
| fact                 | �������ֵĽ׳�     | abs(-1)=1            |
| factdouble           | �������ֵ�˫���׳�     | abs(-1)=1            |
| floor                | ����������Ϊ��ӽ�������     | abs(-1)=1            |
| gcd                  | �������Լ��     | abs(-1)=1            |
| int                  | ����      | abs(-1)=1            |
| lgm                  | ����������������С������      | abs(-1)=1            |
| ln                   | �������ֵ���Ȼ����      | abs(-1)=1            |
| log                  | �������ֵ���Ȼ����      | abs(-1)=1            |
| LOG10                | �������ֵĳ��ö���      | abs(-1)=1            |
| MULTINOMIAL          | ���ز����͵Ľ׳���������׳˳˻��ı�ֵ      | abs(-1)=1            |
| mod                  | ����      | abs(-1)=1            |
| MROUND                  | ����      | abs(-1)=1            |
| int                  | ����      | abs(-1)=1            |
| int                  | ����      | abs(-1)=1            |






