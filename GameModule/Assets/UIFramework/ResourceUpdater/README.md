# unityresupdater
unity resource updater

##��Դ�Զ�����ϵͳ

###��Դ����
1. res.version
2. res.md5
3. res[]

###��ԴĿ¼
1. StreamingAssetPath ����������
2. PersistentAssetPath ���֮�����أ�

    * �����ϴ�����û��ɣ���ʱ���ļ�д��һ��������������ǣ��²�����osӦ�ö�����дdata��sync����дinode��
    * ������װʱ�ϴΰ�װ���£������絼������İ汾����StreamingAssetPath��ģ�
    * ���ܱ��û�ɾ�����գ�ȫ���򲿷֣�
    * ���ܷ��������˰汾

###Ŀ��
1. �ͻ��˶�ȡ��ȷ�汾res
2. ��Ӧ������������Զ��޸���
3. ��һ�����ذ�װ����ѹ��
4. ����û��ֹ��Ķ������ļ����ļ���С���ֲ��䣬���޸���������޸���Ҫÿ����������md5��̫����


###��������

1. CheckVersion 

    * ����res.version��res.version.latest����ȡ2��Ŀ¼res.version��res.version.
    * ������ػ��ȡres.version.latest������Failed��
    * ���res.version.latest == stream/res.version����Succeed��������streamĿ¼���岻���޸ģ�
    * ����Md5Check

2. CheckMd5

    * ���persistent/res.md5������res.version.latest == persistent/res.version ���Զ��޸��Ĺؼ����⣬��������persistentĿ¼�����޸ģ����ε��ǵ����ļ������޸ģ�
       * ��������res.md5.latest��ֻ��ȡ2��Ŀ¼res.md5��
       * ���persistent/res.md5���Ӧ���ļ��Ƿ񶼴��ڣ�����downloadList�������stream��Ƚ�Md5��Size�����ڵĻ���PersistentĿ¼��������ҵ�ȡ�ļ����ȱȽ�Size��������Ȳ�ͬ��ɾ�������������û�ɾ�������ļ�,��2����resû��ɣ���
       * ���downloadListΪ����Succeed��
       * ������������downloadList������DownloadRes��

    * ����
       * ����res.md5.lastest����ȡ2��Ŀ¼res.md5��res.md5.latest��
       * ������ػ��ȡres.md5.latest������Failed��
       * ���res.md5.latest���Ӧ���ļ��Ƿ񶼴��ڣ�����downloadList(�����stream��Ƚ�Md5��Size�����ڵĻ���PersistentĿ¼���ң�����ҵ�ȡ�ļ����ȱȽ�Size��ͬʱ�Ƚ�Persistent��res.md5���Ӧ��Md5��Size�������ͬ��ɾ��)��
       * ��res.md5.lastest������Ϊres.md5��
       * ��res.version.latest������Ϊres.version��
       * ���downloadListΪ����Succeed��
       * ������������downloadList������DownloadRes��

3. DownloadRes
    
    * ������������û���󣬽���Succeed
    * ����Failed

4. Succeed

5. Failed

###ʹ��

1. using(var ru = new ResUpdater(hosts, thread, reporter, startCoroutine)) { ru.Start() }

2. reporter������UI

###Note

1. ��Ȼ���ձ�׼��query_stringʱhttp cacheҪ����query_string ��Ϊkey���������еĿ���ṩ��û����׼��������յĲ��Կ����Ǹ��µ�ʱ����ļ����֡�
�����Ǽ���"?version=md5"�ķ�ʽ������һ��Ҳû���⡣

2. �������û�м����ļ���md5������res.md5�ȶԣ��о�û��Ҫ��Ӧ������tcp�����Ų��ᱻ�м仺��ȡ���ϰ汾��
