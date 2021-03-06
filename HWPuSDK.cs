﻿using System;
using System.Runtime.InteropServices;
using System.Text;


/// <summary>
/// HWPuSDK 的摘要说明。
/// </summary>
public class HWPuSDK
{
    public HWPuSDK()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    #region "宏定义"
    public const int PU_TRUE = 1;//	SDK API调用成功的返回值。
    public const int PU_FALSE = 0;//	SDK API调用失败的返回值。
    public const int PU_RESERVE_LEN = 32;//	预留字节长。
    public const int PU_RESERVE_EX_LEN = 256;//	预留字节长扩充。
    public const int PU_SUBPOLICE_LEN = 32;//	派出所长度
    public const int PU_VERSION_LEN = 32;//	版本信息长度。
    public const int PU_DEVICE_NAME_LEN = 32;//	设备名称长度。
    public const int PU_FAC_NAME_LEN = 12;//	厂商名称长度。
    public const int PU_DEVICE_TYPE_LEN = 32;//	设备类型名称长度。
    public const int PU_SERIAL_LEN = 32;//	序列号长度。
    public const int PU_IP4_ADDR_LEN = 16;//	IPV4地址长度。
    public const int PU_MULTICAST_ADDR_LEN = 32;//	组播地址长度
    public const int PU_IP6_ADDR_LEN = 40;//	IPV6地址长度。
    public const int PU_PLATFORM_INFO_LEN = 32;//	平台信息结构体中的数据长度。
    public const int PU_PTZ_NAME_LEN = 32;//	云台名称长度。
    public const int PU_PTZ_CRUISE_LEN = 32;//	预置位名称长度。
    public const int PU_PTZ_CRUISE_POINT_MAX = 32;//	每条巡航轨迹的最大轨迹点数。
    public const int PU_PTZ_PRESET_NUM = 10;//	查询预置位每次最大支持个数。
    public const int PU_PTZ_GEAR_NUM_MAX = 10;//	云台连续离散档位最大值
    public const int PU_CRUISE_NUM_MAX = 8;//	巡航轨迹最大数
    public const int PU_CRUISE_NAME_LEN = (32 + 4);//	巡航轨迹名字最大长度
    public const int PU_PRIVACY_MASK_MAX = 10;//	最大隐私保护矩形数。
    public const int PU_PRIVACY_MASK_MAX_V2 = 32;//	隐私保护四边形最大值
    public const int PU_PRIVACY_MOSAIC_MAX = 32;//	马赛克矩形，全局球机画面最大值；普通支持4个
    public const int PU_ALARM_TIME_MAX = 8;//	最大告警时间段数。
    public const int PU_ALARM_AREA_MAX = 16;//	最大告警区域数。
    public const int PU_CRUISE_DWELL_MIN = 3;//	巡航轨迹最小停留时间，单位秒。
    public const int PU_CRUISE_DWELL_MAX = 3600;//	巡航轨迹最大停留时间，单位秒。
    public const int PU_CRUISE_SPEED_MIN = 1;//	巡航轨迹最小转动速度。
    public const int PU_CRUISE_SPEED_MAX = 10;//	巡航轨迹最大转动速度。
    public const int PU_TIME_YEAR_LEN = 5;//	年份字符串长度。
    public const int PU_TIME_OTHERS_LEN = 3;//	时间字符串长度。
    public const int PU_TIME_TOTAL_LEN = 32;//	时间字符总串长度。
    public const int PU_UPGRADE_FILE_NUM_MAX = 4;//	上传升级文件最大数。
    public const int PU_UPGRADE_FILE_LEN_MAX = 300;//	升级文件路径长度最大值。
    public const int PU_INVADE_LINE_NUM_MAX = 5;//	入侵检测线的数目最大值。
    public const int PU_SAVE_FILE_PATH_MAX = 128;//	保存文件的最大路径。
    public const int PU_ALARM_CAMERA_MAX = 4;//	最大告警联动镜头数。
    public const int PU_ALARM_DO_MAX = 4;//	最大告警联动输出开关数。
    public const int PU_USER_NAME_LEN = 32;//	用户名最大长度。
    public const int PU_PASSWORD_LEN = 68;//	密码最大长度。
    public const int PU_IMG_QUALITY_INFO_LEN = 1024;//	图片质量判断结果信息的长度
    public const int PU_CAMERA_NUM_MAX = 4;//	设备镜头最大数。
    public const int PU_TRIPWIRE_LEN_NUM_MAX = 5;//	智能绊线告警最大线数。
    public const int PU_IGT_AREA_POINTS_NUM = 10;//	智能区域顶点最大数。
    public const int PU_IGT_AREA_NUM = 4;//	智能最大区域数。
    public const int PU_IGT_LINE_NAME_LEN = 36;//	智能绊线名称长度32字节。
    public const int PU_IGT_AREA_NAME_LEN = 36;//	智能区域名称长度32字节。
    public const int PU_DEVICE_NUM_MAX = 1000;//	SDK最大可接入的前端设备数。
    public const int PU_TRANSPARENT_CMD_MAX = 256;//	透明通道命令长度最大值。
    public const int PU_DOMAIN_LEN = 256;//	域名长度。
    public const int PU_IRLIGHT_NUM_MAX = 4;//	红外球机支持的红外灯个数。
    public const int PU_ROI_AREA_NUM_MAX = 8;//	解码器ROI区域最大数。
    public const int PU_PORT_MODE_NUM_MAX = 16;//	解码器最大端口模式。
    public const int PU_BNC_PORT_MAX = 32;//	解码器最大BNC输出端口。
    public const int PU_VGA_PORT_MAX = 8;//	解码器最大VGA输出端口。
    public const int PU_DVI_PORT_MAX = 8;//	解码器最大DVI输出端口。
    public const int PU_HDMI_PORT_MAX = 8;//	解码器最大HDMI输出端口。
    public const int PU_DECODE_TYPE_MAX = 4;//	解码器解码类型最大数。
    public const int PU_PORT_NUM_MAX = 32;//	解码器最大端口数。
    public const int PU_CHANNEL_NUM_MAX = 32;//	解码器最大通道数。
    public const int PU_OSD_MAX_LENGTH = 97;//	解码器OSD场名最大长度。
    public const int PU_OSD_MAX_LENGTH_EX = 177;//	OSD长度扩充
    public const int PU_CRYPTION_PASSWD_LEN = 44;//	媒体加解密的密钥长度。
    public const int PU_DEC_CHANNEL_NAME_LEN = 32;//	解码器通道名称长度。
    public const int PU_DECODER_ID_LEN = 20;//	解码器ID的长度。
    public const int PU_DECODER_NAME_LEN = 32;//	解码器通道名称长度。
    public const int PU_DEC_PAY_LOAD_TYPE_NUM = 16;//	解码器支持的负载类型最大个数。
    public const int PU_DECODER_ENCODING_LEN = 16;//	解码器编码格式最大长度。
    public const int PU_DIO_NAME_LEN = 36;//	开关量名称长度。
    public const int PU_DIO_NUM_MAX = 8;//	开关量输入/输出最大个数。
    public const int PU_RECORD_PLAN_NUM = 28;//	录像计划条数。
    public const int PU_LOG_TIME_LEN = 20;//	每条日志的时间最大长度
    public const int PU_LOG_LEVEL_LEN = 8;//	每条日志的等级最大长度
    public const int PU_LOG_INFO_LEN = 256;//	每条日志的最大长度。
    public const int PU_LOG_INFO_NUM = 100;//	日志查询每次返回的最大长度。
    public const int PU_NAT_SESSIONID_LEN = 32;//	用于NAT穿越的会话ID长度。
    public const int PU_NAT_URL_LEN = 256;//	用于NAT穿越的会话URL长度。
    public const int PU_RECORD_TYPE_NUM = 4;//	录像类型个数。
    public const int PU_RECORD_INFO_NUM_MAX = 5;//	设备支持的录像信息最大个数。
    public const int PU_RECORD_CONTENTID_LEN = 40;//	录像文件名称的最大长度。
    public const int PU_VIDEO_FORMAT_NUM = 4;//	设备支持的视频编码格式数。
    public const int PU_STREAM_NUM = 4;//	设备支持的最大码流个数。
    public const int PU_OSD_STRING_LEN = 100;//	OSD长度。
    public const int PU_OSD_STRING_NUM = 7;//	OSD字符串个数。
    public const int PU_MAC_ADDR_LEN = 30;//	MAC地址长度。
    public const int PU_SNAP_IMAGE_NAME_LEN = 24;//	抓拍图片文件名长度。
    public const int PU_MAX_URL_LEN = 512;//	URL长度。
    public const int PU_CONFIG_FILE_PATH_MAX = 512;//	配置文件最大路径。
    public const int PU_CONFIG_LOAD_UP_KEY_LEN = 33;//	上传、下载配置文件使用的密钥长度（RSA加密后长度）。
    public const int PU_SNMPV3_USER_NUM = 3;//	SNMP V3用户个数。
    public const int PU_SNMP_COMMUNITY_NUM = 3;//	SNMP V1、V2社团个数。
    public const int PU_SNMP_COMMUNITY_NAME_LEN = 17;//	SNMP V1、V2社团名称长度。
    public const int PU_SNMP_COMMUNITY_NAME_LEN_EX = (32 + 1);//	SNMP V1、V2社团名称长度（拓展）。
    public const int PU_SNMP_TRAP_NUM = 3;//	SNMP Trap个数。
    public const int PU_SNMP_ENGINEID_LEN = 33;//	SNMP ENGINEID长度。
    public const int PU_SNMP_CONTEXT_NAME_LEN = 17;//	SNMP 上下文名长度。
    public const int PU_DEVICE_USER_NUM_MAX = 10;//	设备最大支持10个用户。
    public const int PU_TYPICAL_SCENE_NUM_MAX = 12;//	典型场景套餐个数。
    public const int PU_TYPICAL_SCENE_NUM_MAX_EX = 15;//	扩充后典型场景套餐个数。
    public const int PU_TYPICAL_SCENE_NAME_LEN = 68;//	典型场景名称长度。
    public const int PU_TYPICAL_SCENE_DESCRIBE_LEN = 128;//	典型场景描述。
    public const int PU_PLAN_NUM_MAX = 8;//	计划个数。
    public const int PU_MONTH_NUM = 12;//	月份个数。
    public const int FAC_NAME_LEN_MAX = 12;//	设备厂商名字长度。
    public const int STREAM_PROFILES_MAX = 8;//	最大码流套餐数。
    public const int STREAMPROFILES_NAME_LEN = (64 + 4);//	流套餐名字长度。
    public const int PRIVACY_AREA_POINTS_NUM = 4;//	隐私保护区域顶点数
    public const int ETH_RECV_RATE_MAX = 16000;//	收包速率限制上限
    public const int ETH_RECV_RATE_MIN = 2000;//	收包速率限制下限
    public const int PU_ENC_STREAM_MAX_NUM = 3;//	一个通道最大码流数目
    public const int PU_IP_FILTER_NUM_MAX = 3;//	IP地址过滤最大条目
    public const int PU_CERT_FIELD_NAME_LEN_MAX = (128 + 4);//	证书使用者各字段最大长度
    public const int PU_DDNS_MAX_LEN = 256;//	DDNS
    public const int PU_CLIENT_USERNAME_LEN = (32 + 4);//	FTP用户名最大长度
    public const int PU_FTP_UPLOAD_PATH_LEN = (128 + 4);//	FTP上传目录长度
    /*
    public const int PU_SNMPV3_USER_NUM = 3;//	SNMPv3用户数目
    public const int PU_SNMP_COMMUNITY_NUM = 3;//	社团数目
    public const int PU_SNMP_COMMUNITY_NAME_LEN = (16 + 1);//	社团名字最大长度
    public const int PU_SNMP_COMMUNITY_NAME_LEN_EX = (32 + 1);//	新社团名字最大长度.
    public const int PU_SNMP_TRAP_NUM = 3;//	Trap接收端数目
    public const int PU_SNMP_ENGINEID_LEN = (32 + 1);//	SNMP 引擎Id最大长度
    public const int PU_SNMP_CONTEXT_NAME_LEN = (16 + 1);//	SNMP上下文名最大长度
    */
    public const int OSDI_AREA_NUM_MAX = 8;//	OSDI区域个数
    public const int PU_H264DEC_OK = 0;//	H264解码器成功
    public const int PU_H264DEC_NEED_MORE_BITS = -1;//	H264解码器需要更多位
    public const int PU_H264DEC_NO_PICTURE = -2;//	H264解码器无图片
    public const int PU_H264DEC_ERR_HANDLE = -3;//	H264解码器错误句柄
    public const int PU_SMTP_NAME_LEN_MAX = (32 + 4);//	收件人用户名的长度
    public const int PU_SMTP_MAIL_LEN = 128;//	收件人邮箱的长度
    public const int PU_SMTP_RECV_MAX_NUM = 3;//	收件人列表的最大长度
    public const int MAX_BURST_SHOOTING_NUM = 5;//	最大车牌抓拍数
    public const int MAX_LANE_NUM = 4;//	车道总数
    public const int TDOME_MAX_LANE_NUM = 6;//	交通球车道总数
    public const int MAX_AREA_VERTEX = 5;//	车道结构体总数 MAX_LANE_NUM + 1
    public const int PED_RUN_RED_LINE_NUM = 3;//	行人闯红灯触发线数量
    public const int MAX_PLATE_LOCAL_ZH_LEN = 24;//	默认省份字符长度
    public const int CAM_POSITION_STR_LEN = 15;//	地理位置
    public const int MAX_SUPPLEMENT_LIGHT_LAMP_NUM = 8;//	补光灯个数
    public const int FD_AREA_NUM = 16;//	人脸检测区域个数
    public const int FD_AREA_POINT_NUM = 12;//	人脸检测区域最大顶点个数
    public const int FD_AREA_NAME_LEN = 36;//	人脸检测名称长度
    public const int PU_SNAPSHOT_INQUIRE_NUM = 10;//	一次图片查询的最大图片数量
    public const int PU_SNAPSHOT_PICTURE_NAME_LEN = 64;//	抓拍图片名长度
    public const int PU_VLPR_PIC_OSD_TYPE_MAX = 15;//	OSD最大叠加类型
    public const int PU_VLPR_PIC_OSD_TYPE_MAX_EX = 50;//	OSD最大叠加类型扩充，比智能多预留一些
    public const int PU_MEDIA_ENC_AES_KEY_STR_LEN = 65;//	媒体流加密AES密钥长度
    public const int PU_MEDIA_ENC_AES_CBC_IV_LEN = 17;//	媒体流加密AES CBC模式IV长度
    public const int PU_STREAM_NUM_V2 = 5;//	最大码流个数(从之前的三码流变为五码流)
    public const int PU_OSD_STRING_EX_NUM = 10;//	扩充后OSD字符串个数
    public const int PU_ENC_STREAM_MAX_NUM_V2 = 5;//	一个通道最大码流数目（三码流变五码流）
    public const int VW_VIM_MAX_AREA_POINTS_NUM = 10;//	聚集检测区域最大定点个数
    public const int GATHER_AREA_NAME_LEN = 32;//	聚集检测名称长度
    public const int MAX_AREA_NUM = 4;//	最大区域数目
    public const int PU_IP_FILTER_NUM_MAXV2 = 48;//	IP地址过滤最大条目48个
    public const int PU_IP_FILTER_NUM_MAXV3 = 100;//	IP地址过滤最大条目100个
    public const int PU_HEX_MAC_ADDR_LEN = 18;//	MAC地址长度
    public const int PU_IRCUT_MODE_MAX_NUM = 3;//	ISP视频模式最大值，参见PU_ISP_IRCUT_MODULE_E
    public const int PU_HUMANCOUNT_TABLE_LEN_MAX = 32;//	过线人数表最大长度
    public const int PU_MAX_CUSTOM_CONTENT_LEN = 24;//	目录或者图片名称长度最大值
    public const int PU_MAX_DIR_NAMING_ELEM = 4;//	微卡口款型FTP上传目录级别
    public const int PU_MAX_PIC_NAMING_ELEM = 20;//	FTP上传图片个数最大值
    public const int PU_MAX_PIC_NAMING_ELEM_EX = 90;//	FTP上传图片个数最大值扩充
    public const int PU_MAX_EXT_LAMP_NUM = 8;//	外置灯最大数量
    public const int PU_MAX_INNER_LAMP_NUM = 3;//	内置灯最大数量
    public const int MAX_ITS_SNAPSHOT_INTERVAL = 60000;//	最大抓拍间隔(ms)
    public const int MIN_ITS_SNAPSHOT_INTERVAL = 67;//	最小抓拍间隔(ms)
                                                    //public const int PU_UPGRADE_FILE_NUM_MAX = 16;//	上传升级文件的最大数
    public const int PU_IMPORT_FILE_LEN_MAX = 256;//	上传人脸库文件全路径的最大长度
    public const int PU_IMPORT_FILENAME_LEN_MAX = 128;//	上传人脸库文件名最大长度
    public const int PU_MAX_RECORD_LEN_16 = 16;//	人员信息字符串16位
    public const int PU_MAX_RECORD_LEN_32 = 32;//	人员信息字符串32位
    public const int PU_MAX_RECORD_LEN_48 = 48;//	人员信息字符串48位
    public const int PU_MAX_RECORD_LEN_64 = 64;//	人员信息字符串64位
    public const int PU_MAX_EX_FIELD_LEN = 512;//	人脸信息扩展字段长度
    public const int PU_MAX_DELETE_NUM = 100;//	删除人脸信息的最大条目数
    public const int PU_LIC_SERVICE_AGE_MAX_LEN = 256;//	license服务年限长度
    public const int PU_LIC_REVOKE_KEY_LEN = 136;//	license 失效码长度
    public const int PU_LIC_DATE_MAX_LEN = 72;//	license日期最大长度
    public const int PU_3RD_APP_MAX_NUM = 16;//	第三方算法APP最大数
    public const int PU_ITGT_TYPE_MAX_NUM = 16;//	智能算法种类最大数
    public const int PU_ITGT_TYPE_MAX_EX_NUM = 64;//	智能算法种类最大数
    public const int PU_ITGT_ALTHM_VERSION_LEN = 48;//	智能算法版本号长度
    public const int PU_ITGT_ALTHM_VENDOR_LEN = 48;//	智能算法厂家长度
    public const int PU_ISP_TYPE_MAX_NUM = 64;//	图像算法种类最大数
    public const int PU_OPERATE_3RD_APP_NAME_LEN = 32;//	第三方APP 名称最大长度
    public const int PU_OPERATE_3RD_APP_PATH_LEN = 64;//	第三方APP 文件路径长度
    public const int PU_OPERATE_3RD_APP_CMD_LEN = 128;//	第三方APP 操作命令最大长度
    public const int PU_MANAGE_3RD_APP_NUM_MAX = 1;//	第三方APP 信息最大个数
    public const int PU_MANAGE_3RD_APP_URL_MAX = 64;//	第三方APP url 最大长度
    public const int PU_SNAP_NUM_MAX = 3;//	抓拍最大张数
    public const int PU_SNAP_NUM_MAX2 = 4;//	抓拍最大张数
    public const int ITS_REGULATION_TYPE_NUM_MAX = 32;//	违章类型总数
    public const int ITS_SNAP_NUM_MAX = 4;//	抓拍间隔时间输入总框数
                                          //public const int MAX_LANE_NUM = -4;//	车道总数
    public const int PU_ITS_MAX_LIGHTAREA_NUM = 4;//	ITS红绿灯区域最大数量
    public const int PU_RL_NUM_MAX = 4;//	灯组个数最大值
    public const int PU_RL_NUM_MAX8 = 4;//	灯组个数最大值扩充
    public const int MAX_AREA_POINTS_NUM = 10;//	区域顶点最大数目
    public const int IGT_AREA_NAME_LEN = (32 + 4);//	智能区域名称
    public const int DIAL_APP_LEN_MAX = (32 + 1);//	拨号app最大长度
    public const int DIAL_USR_NAME_LEN_MAX = (32 + 1);//	拨号用户最大长度
    public const int DIAL_PASSWD_LEN_MAX = (32 + 1);//	拨号密码最大长度
    public const int DIAL_PLAN_AREA_MAX = 8;//	拨号区域最大长度
    public const int DIAL_SMS_WHITE_LIST_MAX = 8;//	拨号SMS白名单最大长度
    public const int DIAL_PHONE_NUM_LEN = 16;//	拨号号码长度
    public const int IPV4_ADDR_LEN = 16;//	点分十进制IP地址长度
    public const int DIAL_PLMN_NAME_MAX = 40;//	运营商名称最大长度
    public const int IBALL_MAX_LANE_NUM = 4;//	最大关联车道数
    public const int IBALL_MAX_SNAP_FRAME_NUM = 4;//	抓拍间隔时间输入框总数
    public const int IBALL_MAX_STRING_LENGTH = 256;//	名称最大字符串长度
    public const int MAX_RESTRICTED_NUM = 10;//	限行尾号的总数
    public const int MAX_RESTRICTED_EVENT_NUM = 30;//	限行项总数
    public const int MAX_RESTRICTED_DATE_NUM = 10;//	尾号限行的使能数
    public const int MAX_RESTRICTED_LOCALPLATE_LEN = 5;//	尾号限行本地车牌
    public const int MAX_RESTRICTED_LOCALPLATE_NUM = 32;//	尾号限行本地车牌数量
    public const int MAX_RESTRICTED_LOCALPLATE_ALL_NUM = 26;//	尾号限行本地车牌为全时，记为数量26
    public const int PU_ITS_ILLEGAL_TYPE_NUM_MAX = 96;//	违法字典项数
    public const int PU_ITS_ILLEGAL_TYPE_LEN_MAX = (64 + 4);//	违法类型长度最大值
    public const int PU_ITS_ILLEGAL_NUM_LEN_MAX = (8 + 1);//	违法代码长度最大值
    public const int PU_ITS_ILLEGAL_NAME_LEN_MAX = (64 + 4);//	违法叠加名称长度最大值
    public const int PU_MIN_GPS_SYNC_INTERVAL = (5 * 60);//	GPS同步最小间隔
    public const int PU_MAX_GPS_SYNC_INTERVAL = (1000 * 60);//	GPS同步最大间隔
    public const int TD_MAX_SNAP_FRAME_NUM = 4;//	交通球机最大抓拍帧数
    public const int TD_MAX_SCENE_NUM = 16;//	交通球机最大场景数
    public const int TD_MAX_DAY_ONE_WEEK = 7;//	一周天数
    public const int TD_MAX_STRING_LENGTH = (64 + 1);//	最大字符串长度
    public const int PU_CALIBRATION_POINT_MAX_NUM = 14;//	标定点最大数目
    public const int PU_MASTER_SLAVE_GROUP_MAX_NUM = 4;//	主从组合最大数目
    public const int PU_MASTER_NUM_MAX = 8;//	主设备最大个数
    public const int PU_SLAVE_NUM_MAX = 8;//	从设备最大个数
    public const int PU_1TN_SLAVE_NUM_MAX = 8;//	1拖N从机个数
    public const int PU_ITGT_AUTOTRACKING_PRIORITY_ITEM_NUM = 3;//	机非人自动跟踪优先级Item数量
    public const int PU_MONTH_NUM_PER_YEAR = 12;//	年报表热度图数据长度
    public const int PU_DAY_NUM_PER_MONTH = 31;//	月报表热度图数据长度
    public const int PU_DAY_NUM_PER_WEEK = 7;//	周报表热度图数据长度
    public const int PU_HOUR_NUM_PER_DAY = 24;//	日报表热度图数据长度
    public const int PU_GUARD_PLAN_NUM_PER_DAY = 8;//	每天布防计划个数
    public const int PU_HOTMAP_AREA_NUM = 8;//	最大区域数目
    public const int ITS_ADAPT_SNAP_INTERVAL_NUM_MAX = 2;//	自适应抓拍间隔最大数
    #endregion
    #region"枚举定义"

    #region "错误码"


    /*错误码简要说明：小于10000以下的错误码是SDK返回的错误码，大于10000以上的错误是摄像机返回的错误码。*/
    public const int PU_ERROR_CODE_NOERROR = 0;//	没有错误。
    public const int PU_ERROR_CODE_COMMON_ERROR = 1;//	一般错误。
    public const int PU_ERROR_CODE_PASSWORD_ERROR = 2;//	用户名或密码错误。
    public const int PU_ERROR_CODE_NO_PRIORITY = 3;//	没有操作权限。
    public const int PU_ERROR_CODE_NO_INIT = 4;//	SDK未初始化。
    public const int PU_ERROR_CODE_HAS_INIT = 5;//	SDK已初始化。
    public const int PU_ERROR_CODE_VERSION_NO_MATCH = 6;//	SDK与设备版本不匹配。
    public const int PU_ERROR_CODE_STARTUP_NETWORK_ERROR = 7;//	网络启动错误。
    public const int PU_ERROR_CODE_SOCKET_ERROR = 8;//	网络套接字错误。
    public const int PU_ERROR_CODE_CONNECT_ERROR = 9;//	网络连接错误。
    public const int PU_ERROR_CODE_SEND_TIMEOUT = 10;//	发送消息超时。
    public const int PU_ERROR_CODE_RECV_TIMEOUT = 11;//	接收消息超时。
    public const int PU_ERROR_CODE_OPERATION_TIMEOUT = 12;//	设备操作超时。
    public const int PU_ERROR_CODE_OUT_OF_MEMORY = 13;//	内存不足，无法分配内存。
    public const int PU_ERROR_CODE_SERVER_IS_SHUTDOWN = 14;//	服务端关闭连接。
    public const int PU_ERROR_CODE_TOO_MANY_REALPLAY = 15;//	实况路数超过最大值。
    public const int PU_ERROR_CODE_LOG_ERROR = 16;//	日志出错。
    public const int PU_ERROR_CODE_NO_FREE_PORT = 17;//	没有多余的端口资源。
    public const int PU_ERROR_CODE_HAS_REG_EVENT_CALLBACK = 18;//	事件回调函数已注册
    public const int PU_ERROR_CODE_REGISTER_FAIL = 19;//	前端主动注册平台失败
    public const int PU_ERROR_CODE_REGISTER_REDIRECT = 20;//	前端主动注册平台重定向
    public const int PU_ERROR_CODE_INPUT_NULL_PTR = 21;//	输入参数为空指针
    public const int PU_ERROR_CODE_OPR_LOCAL_FILE_FAIL = 22;//	操作本地文件失败
    public const int PU_ERROR_CODE_FILE_FORMAT_INVALID = 23;//	文件格式错误
    public const int PU_ERROR_CODE_VLPR_WATERMARK_INVALID = 24;//	抓拍图片数字水印校验失败
    public const int PU_ERROR_CODE_REST_PKG_TYPE_ERROR = 25;//	REST协议报文格式错误

    public const int PU_ERROR_CODE_SDKINIT_LINK_MODE_ERROR = 101;//	SDK初始化连接模式出错。
    public const int PU_ERROR_CODE_SDKINIT_LOCALIP_ERROR = 102;//	SDK初始化本地IP出错。
    public const int PU_ERROR_CODE_SDKLOGIN_PARA_ERROR = 103;//	登录参数错误。
    public const int PU_ERROR_CODE_CODE_IS_INVALID = 104;//	错误码无效。
    public const int PU_ERROR_CODE_SDKGETVERSION_PARA_ERROR = 105;//	获取版本参数出错。
    public const int PU_ERROR_CODE_IDENTIFYID_ERROR = 106;//	错误的用户ID号。
    public const int PU_ERROR_CODE_SDKGETDEVICE_PARA_ERROR = 107;//	获取设备参数错误。
    public const int PU_ERROR_CODE_ALARMREPORT_CB_IS_NULL = 108;//	告警上报回调函数为空。
    public const int PU_ERROR_CODE_VOICETB_CB_IS_NULL = 109;//	语音对讲回调函数为空。
    public const int PU_ERROR_CODE_REALPLAY_CB_IS_NULL = 110;//	实况播放回调函数为空。
    public const int PU_ERROR_CODE_LOAD_PLAYDLL_ERROR = 111;//	加载播放库出错。
    public const int PU_ERROR_CODE_CFGFILE_ERROR = 112;//	配置文件出错。
    public const int PU_ERROR_CODE_UNSUPPORT_ALARM_TYPE = 113;//	未知告警类型。
    public const int PU_ERROR_CODE_SDKUPGRADE_PARA_ERROR = 114;//	升级参数错误。
    public const int PU_ERROR_CODE_SDKUPGRADE_ERROR = 115;//	升级错误。
    public const int PU_ERROR_CODE_SDKUPGRADE_FILE_ERROR = 116;//	升级文件错误。
    public const int PU_ERROR_CODE_UNSUPPORT_PLATFORM_TYPE = 117;//	未知平台类型。
    public const int PU_ERROR_CODE_SDKSETPLATFORM_PARA_ERROR = 118;//	设置平台参数出错。
    public const int PU_ERROR_CODE_UNSUPPORT_ENCODE_TYPE = 119;//	未知音视频编码类型。
    public const int PU_ERROR_CODE_UNSUPPORT_STREAM_TYPE = 120;//	未知码流类型。
    public const int PU_ERROR_CODE_UNSUPPORT_BITRATE_TYPE = 121;//	未知码率类型。
    public const int PU_ERROR_CODE_UNSUPPORT_PTZ_CMD = 122;//	未知云台命令。
    public const int PU_ERROR_CODE_CRUISE_PARA_ERROR = 123;//	巡航轨迹参数错误。
    public const int PU_ERROR_CODE_ALARM_TMP_PARA_ERROR = 124;//	温度告警参数错误。
    public const int PU_ERROR_CODE_ALARM_MOTION_DETEC_PARA_ERROR = 125;//	移动侦测告警参数错误。
    public const int PU_ERROR_CODE_ALARM_INPUT_PARA_ERROR = 126;//	输入告警参数错误。
    public const int PU_ERROR_CODE_ALARM_HIDE_PARA_ERROR = 127;//	遮挡告警参数错误。
    public const int PU_ERROR_CODE_ALARM_INVADE_PARA_ERROR = 128;//	入侵检测告警参数错误。
    public const int PU_ERROR_CODE_ALARM_COUNT_PARA_ERROR = 129;//	目标计数告警参数错误。
    public const int PU_ERROR_CODE_ALARM_DISTURB_PARA_ERROR = 130;//	干扰告警参数错误。
    public const int PU_ERROR_CODE_PRIVACY_PARA_ERROR = 131;//	隐私保护参数错误。
    public const int PU_ERROR_CODE_OSD_PARA_ERROR = 132;//	OSD参数错误。
    public const int PU_ERROR_CODE_PTZ_PARA_ERROR = 133;//	云台控制参数错误。
    public const int PU_ERROR_CODE_SDKGUARD_PARA_ERROR = 134;//	布撤防参数错误。
    public const int PU_ERROR_CODE_SDKGETALARAM_PARA_ERROR = 135;//	获取告警参数错误。
    public const int PU_ERROR_CODE_PARA_ERROR = 136;//	参数出错。
    public const int PU_ERROR_CODE_PLAYER_FUNC_ERROR = 137;//	播放库函数调用出错。
    public const int PU_ERROR_CODE_SDKSAVEREALDATA_ERROR = 138;//	保存实况数据。
    public const int PU_ERROR_CODE_SDKGETGUARDSTATE_PARA_ERROR = 139;//	获取布防状态参数出错。
    public const int PU_ERROR_CODE_MUTUALLYEXCLUSIVE_RELATIONSHIP = 140;//	因互斥关系而导致不能设置成功
    public const int PU_ERROR_CODE_DEVICE_RELOGIN = 141;//	重复登录设备。
    public const int PU_ERROR_CODE_INVALID_CONFIG_FILE = 142;//	配置文件不合法。
    public const int PU_ERROR_CODE_WRONG_RSP_TYPE = 143;//	响应消息类型错误
    public const int PU_ERROR_CODE_RSP_MEG_PARSE_ERROR = 144;//	响应消息解析失败
    public const int PU_ERROR_CODE_MISMATCH_PWD_COMPLEXITY = 145;//	密码不符合密码复杂度要求
    public const int PU_ERROR_CODE_ALARM_AUDIO_UP_PARA_ERROR = 146;//	音频陡升告警参数错误
    public const int PU_ERROR_CODE_ALARM_AUDIO_DOWN_PARA_ERROR = 147;//	音频陡降告警参数错误
    public const int PU_ERROR_CODE_TRANSPARENT_CHANNEL_DATA_CB_IS_NULL = 148;//	透明通道数据回调函数为空
    public const int PU_ERROR_CODE_NO_ENOUGH_CONTINUOUS_MEM = 149;//	不存在足够的连续内存
    public const int PU_ERROR_CODE_IRCMODE_PARA_ERROR = 150;//	IRCUT模式类型错误
    public const int PU_ERROR_CODE_CERT_PARA_ERROR = 151;//	证书路径错误
    public const int PU_ERROR_CODE_IMPORT_FACELIBRARY_ERROR = 152;//	人脸库导入错误
    public const int PU_ERROR_CODE_IMPORTING_FACELIB_ERROR = 153;//	人脸库正在导入
    public const int PU_ERROR_CODE_UNKNOWN_SV_TYPE = 154;//	未知的业务类型
    public const int PU_ERROR_CODE_NOT_OPEN_TLS = 155;//	未开启TLS，不能操作人脸库相关
    public const int PU_ERROR_INVALID_UPDATEFILE_NUM = 156;//	升级文件数量超出限制
    public const int PU_ERROR_USER_CANCEL_UPGRADE = 157;//	用户取消升级
    public const int PU_ERROR_NOT_ENOUGH_MEMORY_ALLOCATED = 160;//	输入接收缓存过小，无法加载JSON数据
    public const int PU_ERROR_MUTUALAUTH_ERROR = 161;//	反向认证失败

    public const int PU_ERROR_CODE_GetConfigFile = 162;//	正在获取配置文件
    public const int PU_ERROR_CODE_GetFaceLib = 163;//	正在获取人脸库信息
    public const int PU_ERROR_CODE_GetFaceInfo = 164;//	正在获取人脸信息
    public const int PU_ERROR_CODE_ManualSnapshot = 165;//	正在手动抓拍
    public const int PU_ERROR_CODE_OneKeyCollection = 166;//	正在一键收集
    public const int PU_ERROR_CODE_GetFacePic = 167;//	正在获取人脸图片
    public const int PU_ERROR_CODE_GetImportCsv = 168;//	正在获取人脸导库结果
    public const int PU_ERROR_CODE_GetHotMap = 168;//	正在获取热度图
    public const int PU_ERROR_CODE_GetQualityJudge = 169;//	正在获取图片质量判断结果

    public const int PU_ERROR_HTTP_BAD_REQUEST = 400;//	HTTP 无效命令
    public const int PU_ERROR_HTTP_CONFLICT = 409;//	HTTP 命令冲突

    public const int PU_ERROR_CODE_DEC_INITDEC_ERROR = 1001;//	初始化解码失败。
    public const int PU_ERROR_CODE_DEC_STARTDEC_ERROR = 1002;//	开始解码失败。
    public const int PU_ERROR_CODE_DEC_STOPDEC_ERROR = 1003;//	停止解码失败。
    public const int PU_ERROR_CODE_DEC_TOO_MANY_CHANNEL = 1004;//	太多的解码通道。
    public const int PU_ERROR_CODE_DEC_ERROR_PORT_NUM = 1005;//	端口数错误。
    public const int PU_ERROR_CODE_DEC_ERROR_DEC_HANDEL = 1006;//	错误的解码句柄。
    public const int PU_ERROR_CODE_DEC_ERROR_UNSUPPORT_DECODE_TYPE = 1007;//	不支持的解码类型。
    public const int PU_ERROR_CODE_DEC_ERROR_INVALID_CHANNEL_ID = 1008;//	无效的通道号。

    public const int PU_ERROR_CODE_SERVER_COMMON_ERROR = 10001;//	一般错误。
    public const int PU_ERROR_CODE_SYNTAX_ERROR = 10002;//	配置语法错误。
    public const int PU_ERROR_CODE_UNSUPPORT_ERROR = 10003;//	不支持的请求。
    public const int PU_ERROR_CODE_PARAMETER_ERROR = 10004;//	参数错误。
    public const int PU_ERROR_INVALID_VCU_ID = 10005;//	设备ID错误。
    public const int PU_ERROR_CODE_INVALID_CHANNEL = 10006;//	通道号错误。
    public const int PU_ERROR_CODE_INVALID_SERIAL_NO = 10007;//	串口号错误。
    public const int PU_ERROR_CODE_INVALID_ALARM_NO = 10008;//	报警端口错误。
    public const int PU_ERROR_CODE_UNSUPPORTED_MEDIA_TYPE = 10009;//	不支持的媒体类型。
    public const int PU_ERROR_CODE_PARTLY_SUPPORT = 10011;//	仅部分参数配置成功。
    public const int PU_ERROR_CODE_TOO_MANY_PLANS = 10012;//	计划条数超过限制。
    public const int PU_ERROR_CODE_NO_DISK = 10013;//	设备无硬盘。
    public const int PU_ERROR_CODE_OPEN_SOUND_FAIL = 10014;//	打开声音失败。
    public const int PU_ERROR_CODE_VOICE_OPEND = 10015;//	服务器语音对讲被占用。
    public const int PU_ERROR_CODE_DEVICE_BUSY = 10016;//	设备忙。
    public const int PU_ERROR_CODE_OPERATE_FLASH_ERROR = 10019;//	FLASH出错。
    public const int PU_ERROR_CODE_UNSUPPORTED_VIDEO_FORMAT = 10020;//	不支持的视频制式。
    public const int PU_ERROR_CODE_IP_ADDRESS_CONFLICT = 10022;//	IP地址冲突。
    public const int PU_ERROR_CODE_LTE_DHCP_CONFLICT = 10023;//	设置LTH和DHCP冲突
    public const int PU_ERROR_CODE_SIP_STACK_ERROR = 10024;//	SIP协议栈错误
    public const int PU_ERROR_CODE_RESULT_UNSUPPORTED_DEST = 10031;//	对应服务或者APP无法访问

    public const int PU_ERROR_CODE_NULL_ELEMENT = 10101;//	XML文件没有相应节点
    public const int PU_ERROR_CODE_INVALID_VERIFICATION = 10102;//	无效的用户名或密码。
    public const int PU_ERROR_CODE_INVALID_VERSION_FILE = 10103;//	VERSION文件校验失败。
    public const int PU_ERROR_CODE_INVALID_KERNEL_FILE = 10104;//	内核升级文件校验失败。
    public const int PU_ERROR_CODE_INVALID_ROOTFS_FILE = 10105;//	文件系统升级文件校验失败。
    public const int PU_ERROR_CODE_FIRST_LOGIN = 10106;//	第一次登录。
    public const int PU_ERROR_CODE_CLIENT_ALREADY_LOGIN = 10107;//	已有客户端登录。
    public const int PU_ERROR_CODE_USER_LOCKED = 10108;//	用户被锁定。
    public const int PU_ERROR_CODE_MANY_USER = 10109;//	用户个数超过限制。
    public const int PU_ERROR_CODE_USER_NAME_CONFLICT = 10110;//	用户名冲突。
    public const int PU_ERROR_CODE_NO_USER_NAME = 10111;//	没有该用户。
    public const int PU_ERROR_CODE_USER_NOPOWER = 10112;//	当前用户没该权限。
    public const int PU_ERROR_CODE_NOT_NEED_UPDATE = 10113;//	版本号一致，不需要升级。
    public const int PU_ERROR_CODE_NOT_SUPPORT_ABILITY = 10114;//	不支持的能力参数。
    public const int PU_ERROR_CODE_PRESET_IN_GUARD_POSITION = 10115;//	预置位在看守位中。
    public const int PU_ERROR_CODE_PRESET_IN_CRUISE_TRACK = 10116;//	预置位在巡航轨迹中。
    public const int PU_ERROR_CODE_THE_CRUISE_IS_RUNNING = 10122;//	巡航轨迹正在运行。
    public const int PU_ERROR_CODE_UPDATE = 10125;//	系统正在升级。
    public const int PU_ERROR_CODE_REBOOT = 10126;//	系统正在重启。
    public const int PU_ERROR_CODE_RESTORE = 10127;//	正在恢复默认配置。
    public const int PU_ERROR_CODE_RECOVER_OPRATE_FORBIDDEN = 10128;//	恢复默认配置禁止配置等操作。
    public const int PU_ERROR_CODE_ROI_ERROR_BY_MJPEG = 10129;//	MJPEG下设置ROI失败。
    public const int PU_ERROR_CODE_ROI_ERROR_BY_NOSUBSTREAM = 10130;//	只有主码流，设置子码流ROI失败。
    public const int PU_ERROR_CODE_TZ_ERROR_BY_CONFLICT = 10131;//	设置越线检测使能有冲突
    public const int PU_ERROR_CODE_OC_ERROR_BY_CONFLICT = 10132;//	设置目标计数使能有冲突。
    public const int PU_ERROR_CODE_MD_ERROR_BY_CONFLICT = 10133;//	设置移动侦测使能有冲突。
    public const int PU_ERROR_CODE_TW_ERROR_BY_CONFLICT = 10134;//	设置越线检测使能有冲突。
    public const int PU_ERROR_CODE_AREA_ERROR_BY_CONFLICT = 10135;//	设置区域检测使能有冲突。
    public const int PU_ERROR_CODE_VD_ERROR_BY_CONFLICT = 10136;//	设置视频干扰使能有冲突。
    public const int PU_ERROR_CODE_IGT_ENABLE_CONFLICT = 10137;//	智能开关已打开，设置照度增强失败,设置视频遮挡使能冲突。
    public const int PU_ERROR_CODE_ILLUMINATION_ENABLE_CONFLICT = 10138;//	照度开关已使能，设置智能开关或者视频遮挡使能冲突。
    public const int PU_ERROR_CODE_VIDEOBLOCK_ENABLE_CONFLICT = 10139;//	视频遮挡已使能，设置智能开关或照度增强使能冲突。
    public const int PU_ERROR_CODE_IGT_FAIL_BY_SWITCHOFF = 10140;//	智能开关未使能，设置智能业务失败。
    public const int PU_ERROR_CODE_TW_ERROR_BY_OVER_NUM = 10141;//	设置绊线条数超过最大数。
    public const int PU_ERROR_CODE_AREA_ERROR_BY_OVER_NUM = 10142;//	设置区域个数超过最大数4。
    public const int PU_ERROR_CODE_AREA_ERROR_BY_OVER_TOTAL_NUM = 10143;//	设置区域个数超过最大总数10。
    public const int PU_ERROR_CODE_AREA_ERROR_BY_ZERO_NUM = 10144;//	设置区域个数为0。
    public const int PU_ERROR_CODE_AREA_POINT_ERROR_BY_OVER_NUM = 10145;//	设置区域顶点数超过最大数。
    public const int PU_ERROR_CODE_AREA_ABN_ERROR_BY_CONFLICT = 10146;//	设置区域检物品移走，遗留使能已开启有冲突。
    public const int PU_ERROR_CODE_AREA_RMV_ERROR_BY_CONFLICT = 10147;//	设置区域检物品遗留，移走使能已开启有冲突。
    public const int PU_ERROR_CODE_VIM_GLOBAL_PARA_ERROR = 10148;//	设置智能分析算法全局参数失败。
    public const int PU_ERROR_CODE_AREA_NOTSURPORT_ERROR = 10149;//	设置智能分析区域无效。
    public const int PU_ERROR_CODE_PRIVACY_MASK_AREA_BEYOND = 10150;//	隐私保护区域超出总面积。
    public const int PU_ERROR_CODE_MEDIA_ADAPT_BW_MUTEX = 10151;//	带宽自适应与编码类型或者码率类型冲突。
    public const int PU_ERROR_CODE_IP_FILTER_RULE_SAME = 10152;//	存在相同的IP过滤规则。
    public const int PU_ERROR_CODE_WD_FRAME_CONFLICT = 10153;//	宽动态模式为手动或自动时，设置采集帧率50或60帧冲突。
    public const int PU_ERROR_CODE_FRAME_WD_CONFLICT = 10154;//	采集帧率为50或60帧时，设置宽动态手动或自动模式冲突。
    public const int PU_ERROR_CODE_CONFLICT_VIDEOBLOCK_OR_IGT_IS_ENABLE = 10155;//	视频遮挡或者智能开关已使能，设照度增强使能冲突。
    public const int PU_ERROR_CODE_BUSY_CURISE = 10156;//	正在巡航，无法设置巡航轨迹参数。
    public const int PU_ERROR_CODE_DEVICE_CLOSE = 10157;//	设备未开启。
    public const int PU_ERROR_CODE_BUSY_PRESET = 10158;//	预置位被使用，无法删除。
    public const int PU_ERROR_CODE_INVALID_IGT_AREA_ID = 10159;//	智能分析区域不存在。
    public const int PU_ERROR_CODE_INVALID_IGT_LINE_ID = 10160;//	智能分析线条不存在。
    public const int PU_ERROR_CODE_INVALID_PRIVACY_ID = 10161;//	隐私保护区域不存在。
    public const int PU_ERROR_CODE_IN_USER_DEFINE_SCAN = 10162;//	正在花样扫描录制（与很多功能冲突）
    public const int PU_ERROR_CODE_SET_DRC_BACKLIGHT_CONFLICT = 10163;//	背光补偿使能与DRC使能冲突
    public const int PU_ERROR_CODE_CURISE_IN_GUARD_POSITION = 10164;//	巡航轨迹在看守位中
    public const int PU_ERROR_CODE_DISK_ABNORMAL = 10165;//	SD卡异常
    public const int PU_ERROR_CODE_PRIVACYMASK_REGION_INTERSECT = 10166;//	隐私保护区域重叠
    public const int PU_ERROR_CODE_INVALID_SAMEPASSWD = 10167;//	修改密码与原密码相同
    public const int PU_ERROR_CODE_NOT_SUPPORTED_UPDATE = 10168;//	升级文件版本过低，请选择高版本升级
    public const int PU_ERROR_CODE_MANY_RECORD_FILES = 10169;//	录像或图片文件过多
    public const int PU_ERROR_CODE_CONFLICT_WITH_MOSAIC = 10170;//	操作与马赛克冲突
    public const int PU_ERROR_CODE_CONFLICT_WITH_OSD = 10171;//	操作与OSD冲突
    public const int PU_ERROR_CODE_CONFLICT_WITH_PIC = 10172;//	操作与图片叠加冲突
    public const int PU_ERROR_CODE_VIDEO_ENC_CLOSE = 10173;//	视频编码器未打开
    public const int PU_ERROR_CODE_ISP_PARA_CONFLICT = 10174;//	ISP参数冲突
    public const int PU_ERROR_CODE_WB_HIGH_TEMP_LOWER = 10175;//	白平衡自动追踪模式下色温下限大于等于色温上限
    public const int PU_ERROR_CODE_MJPEG_UNSUPPORT_WATERMARK = 10176;//	MJPEG不支持数字水印功能
    public const int PU_ERROR_CODE_ISP_CONFLICT_WITH_FRAMERATE = 10177;//	宽动态/背光补偿与全帧率互斥
    public const int PU_ERROR_CODE_FRAMERATE_CONFLICT_WITH_ISP = 10178;//	//50帧/60帧与宽动态/背光补偿互斥
    public const int PU_ERROR_CODE_OSD_STRING_LEN_ERR = 10179;//	OSD字符长度错误
    public const int PU_ERROR_CODE_DISK_MOUNT_ERROR = 10183;//	磁盘未挂载
    public const int PU_ERROR_CODE_IMPORTING_FACE_LIB = 10184;//	正在导入人脸库，稍后
    public const int PU_ERROR_CODE_ADDING_ONE_FACE = 10185;//	正在添加人脸，稍后
    public const int PU_ERROR_CODE_EXTRA_DEVICE_OPEN_FAIL = 10190;//	外设开启失败

    public const int PU_ERROR_CODE_AUDIO_DETECT_MIC_NOT_SUPPORT = 10200;//	音频输入为mic in模式下不支持音频异常检测
    public const int PU_ERROR_CODE_CIF_CONFLICT = 10202;//	因与走廊互斥，CIF不可设
    public const int PU_ERROR_CODE_CORRIDOR_CONFLICT = 10203;//	因与CIF互斥，走廊不可设
    public const int PU_RESULT_ERR_POINT_OUTOF_RANGE = 10211;//	  
    public const int PU_RESULT_ERR_LINE_BECOME_POINT = 10212;//	  
    public const int PU_RESULT_ERR_LINE_CROSS = 10213;//	  

    public const int PU_ERROR_ISP_AE_MANUAL_CONFLICT_WD = 10214;//	手动曝光与宽动态互斥
    public const int PU_ERROR_ISP_AE_MANUAL_CONFLICT_FLICKER = 10215;//	手动曝光与背景频率互斥
    public const int PU_ERROR_ISP_AE_MANUAL_CONFLICT_HLC = 10216;//	手动曝光与强光抑制
    public const int PU_ERROR_ISP_AE_SHUTPRI_CONFLICT_WD = 10217;//	曝光模式快门优先与宽动态互斥
    public const int PU_ERROR_ISP_AE_SHUTPRI_CONFLICT_FLICKER = 10218;//	曝光模式快门优先与背景频率互斥
    public const int PU_ERROR_ISP_AE_SHUTPRI_CONFLICT_HLC = 10219;//	曝光模式快门优先与强光抑制
    public const int PU_ERROR_ISP_BACKLIGHT_CONFLICT_WD = 10220;//	背光补偿与宽动态互斥
    public const int PU_ERROR_ISP_BACKLIGHT_CONFLICT_HLC = 10221;//	背光补偿与强光抑制互斥
    public const int PU_ERROR_ISP_WD_CONFLICT_HLC = 10222;//	宽动态与强光抑制互斥
    public const int PU_ERROR_ISP_DEFOG_CONFLICT_WD = 10223;//	透雾模式与宽动态互斥
    public const int PU_ERROR_ISP_HLC_CONFLICT_FRAMERATE = 10224;//	强光抑制与50帧60帧互斥
    public const int PU_ERROR_ISP_WD_CONFLICT_FRAMERATE = 10225;//	宽动态与50帧60帧互斥
    public const int PU_ERROR_ISP_AE_MANUAL_CONFLICT_BACKLIGHT = 10226;//	手动曝光与背光补偿
    public const int PU_ERROR_ISP_HLC_CONFLICT_SLOW_SHUTTER = 10227;//	强光抑制与慢快门互斥
    public const int PU_ERROR_ISP_WD_CONFLICT_SLOW_SHUTTER = 10228;//	宽动态与慢快门互斥

    public const int PU_ERROR_CODE_DOWNLOAD_FILE_ERROR = 10300;//	文件下载失败
    public const int PU_ERROR_CODE_CONNECTION_SERVER_INTERRUPTED = 10301;//	连接服务器中断
    public const int PU_ERROR_CODE_REQUEST_OVERTIME = 10302;//	请求超时
    public const int PU_ERROR_CODE_CONNECTION_SERVER_FAIL = 10303;//	连接服务器失败
    public const int PU_ERROR_CODE_CONNECTION_NOT_FOUND = 10304;//	连接未找到
    public const int PU_ERROR_CODE_RECONNECTING_TO_SERVER = 10305;//	正在重新连接服务器
    public const int PU_ERROR_CODE_FILE_NOT_EXIST = 10306;//	文件不存在

    public const int PU_ERROR_CODE_INVALID_UPDATEFILE = 10310;//	升级文件非法
    public const int PU_ERROR_CODE_UPDATEFILE_BAD = 10311;//	文件损坏。
    public const int PU_ERROR_CODE_INVALID_FILE_FORMAT = 10312;//	文件格式错误。

    public const int PU_ERROR_CODE_UPGRADE_TYPE_ERR = 10350;//	升级文件类型与请求类型不符
    public const int PU_ERROR_CODE_UPGRADE_PARAM_NULL = 10351;//	升级参数为空
    public const int PU_ERROR_CODE_UPGRADE_NOT_UPLOAD = 10352;//	升级文件未上传
    public const int PU_ERROR_CODE_UPGRADE_VERIFY_FAIL = 10353;//	升级文件完整性校验失败
    public const int PU_ERROR_CODE_UPGRADE_SIGN_FAIL = 10354;//	升级文件数字签名验证失败
    public const int PU_ERROR_CODE_UPGRADE_SPACE_FULL = 10355;//	升级存储空间满
    public const int PU_ERROR_CODE_UPGRADE_DEVICE_FAIL = 10356;//	设备支持列表适配失败
    public const int PU_ERROR_RESULT_ALG_VER_ERR_U = 10357;//	算法包版本错误(算法需要和软件包VRC版本一致)
    public const int PU_ERROR_RESULT_ALG_VER_NEED_UPGRADE_U = 10358;//	版本包升级后提示需要升级算法包

    public const int PU_ERROR_SD_NOT_FORMAT = 10601;//	SD卡未格式化
    public const int PU_ERROR_CODE_CUSTOM_PACKAGE_UNDEFINED = 10602;//	码流套餐、ISP套餐未定义
    public const int PU_ERROR_CODE_PTZ_BUSY = 10603;//	云台未停止

    public const int PU_ERROR_CODE_OSDI_AREA_NOT_EXIST = 10700;//	区域不存在，索引值错误
    public const int PU_ERROR_CODE_OSDI_AREA_TOO_LARGE = 10701;//	区域水平宽度超过180度
    public const int PU_ERROR_CODE_OSDI_AREA_INVALID_VERDEGREE = 10702;//	区域坐标点不符合左下右上规则
    public const int PU_ERROR_CODE_OSDI_INDEX_AlREADY_EXIST = 10705;//	新增区域索引号非法，索引已存在
    public const int PU_ERROR_CODE_OSDI_HOR_OR_VER_EQUAL = 10708;//	区域坐标点水平或垂直坐标相等
    public const int PU_ERROR_CODE_OSDI_INDEX_INVALID = 10709;//	区域索引号非法，小于1
    public const int PU_ERROR_CODE_OSDI_INDEX_EQUAL = 10710;//	区域索引号重复

    public const int PU_ERROR_CODE_DST_ALREADY_OPEN = 10800;//	夏令时已经打开
    public const int PU_ERROR_CODE_SET_TIME_OUT_OF_RANGE = 10801;//	设置时间超出系统时间范围
    public const int PU_STABILIZER_CONFLICT_AREA_CROP = 10900;//	防抖与区域裁剪互斥
    public const int PU_AREA_CROP_CONFLICT_STABILIZER = 10901;//	区域裁剪与防抖互斥
    public const int PU_RESULT_STABILIZER_CONFLICT_VLPR = 10902;//	电子防抖动业务与车牌检测互斥
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_POINT_NULL = 10950;//	指针为空
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_READ_FILE = 10951;//	读取文件失败
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_XML_PARSER = 10952;//	XML解析失败
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_IMG_TPYE = 10953;//	图片类型不支持
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_RESOLUTION_DIFF = 10954;//	分辨率与初始不同
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_VERTEX_ILLEGAL = 10955;//	点坐标不合理
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_RESOLUTION_UNSUPPORT = 10956;//	分辨率不支持
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_PARAM_ERR = 10957;//	参数错误
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_MALLOC_FAILED = 10958;//	内存分配失败
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_NOT_CONFIG = 10961;//	配置出错
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_PARAM_SET = 10962;//	参数设置错误
    public const int PU_ERROR_CODE_ITGT_IMRS_ERR_LANE_OVERLAP = 10963;//	车道线错误
    public const int PU_ERROR_RESULT_VLPR_ERR_LINE_OUTOF_RANGE = 10964;//	设置失败，检测线不在车道线范围内
    public const int PU_ERROR_CODE_SHORT_KEY = 11001;//	证书密钥过短
    public const int PU_ERROR_CODE_WEAK_CERT = 11002;//	证书密钥过弱
    public const int PU_ERROR_CODE_GET_TEMPERTURE_VW_RET_FAIL = 11024;//	从驱动获取温度失败
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_TYPE = 11100;//	车道线类型超出范围
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_NUM = 11101;//	车道个数不在有效范围内
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_DIR = 11102;//	车道方向无效
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_DRV_DIR = 11103;//	车道行驶方向无效
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_PURPOSE = 11104;//	车道用途无效
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_ATTR = 11105;//	车道属性无效
    public const int PU_RESULT_ITS_ERR_INVALID_CAR_DRV_DIR = 11106;//	行驶方向无效
    public const int PU_RESULT_ITS_ERR_INVALID_SIGN_DIR = 11107;//	指示方向无效
    public const int PU_RESULT_ITS_ERR_INVALID_NORMAL_SIGN_SPEED = 11108;//	小车标志速度无效
    public const int PU_RESULT_ITS_ERR_INVALID_NORMAL_LOW_SPEED = 11109;//	小车限制低速无效
    public const int PU_RESULT_ITS_ERR_INVALID_NORMAL_HIGH_SPEED = 11110;//	小车限制高速无效
    public const int PU_RESULT_ITS_ERR_INVALID_BIGVEHICLE_SIGN_SPEED = 11111;//	大车标志速度无效
    public const int PU_RESULT_ITS_ERR_INVALID_BIGVEHICLE_LOW_SPEED = 11112;//	大车限制低速无效
    public const int PU_RESULT_ITS_ERR_INVALID_BIGVEHICLE_HIGH_SPEED = 11113;//	大车限制高速无效
    public const int PU_RESULT_ITS_ERR_INVALID_EXTERN_LAMP_BITMAP = 11114;//	外置灯关联无效
    public const int PU_RESULT_ITS_ERR_INVALID_SNAP_INTERVAL = 11115;//	抓拍间隔不在有效范围内
    public const int PU_RESULT_ITS_ERR_INVALID_DT_TYPE = 11116;//	检测方式不在有效范围内
    public const int PU_RESULT_ITS_ERR_INVALID_REGULATION_NUM = 11117;//	违章数目超出限制
    public const int PU_RESULT_ITS_ERR_INVALID_REGULATION_TYPE = 11118;//	违章类型无效
    public const int PU_RESULT_ITS_ERR_INVALID_SNAP_NUM = 11119;//	违章抓拍张数不在有效范围内
    public const int PU_RESULT_ITS_ERR_INVALID_RUNNINGRED_PRIORITY = 11120;//	闯红灯优先级无效
    public const int PU_RESULT_ITS_ERR_INVALID_OVER_LANE_SENSITIVITY = 11121;//	压车道线灵敏度无效
    public const int PU_RESULT_ITS_ERR_INVALID_VINBIKELANE_STAYTIME = 11122;//	机占非停留时间无效
    public const int PU_RESULT_ITS_ERR_INVALID_OVER_BUSLANE_STAYTIME = 11123;//	占用公交车道时间无效
    public const int PU_RESULT_ITS_ERR_INVALID_PARKINGTIME = 11124;//	黄网格线停留时间无效
    public const int PU_RESULT_ITS_ERR_INVALID_LIGHT_DT_TYPE = 11125;//	信号灯接入方式不在有效范围内
    public const int PU_RESULT_ITS_ERR_INVALID_LIGHT_AREA_NUM = 11126;//	信号灯区域数目无效
    public const int PU_RESULT_ITS_ERR_INVALID_LIGHT_NUM = 11127;//	信号灯个数无效
    public const int PU_RESULT_ITS_ERR_INVALID_LIGHT_ARRANGE_TYPE = 11128;//	信号灯方向无效
    public const int PU_RESULT_ITS_ERR_INVALID_YELLOW_TIME = 11129;//	黄灯持续时间无效
    public const int PU_RESULT_ITS_ERR_INVALID_LIGHT_AREA = 11130;//	信号灯区域无效
    public const int PU_RESULT_ITS_ERR_LINE_OUTOF_RANGE = 11131;//	检测线、停止线不在车道线或右边界线有效范围内
    public const int PU_RESULT_ITS_ERR_INVALID_NORMAL_SPEED_RANGE_CONFIG = 11132;//	若小车限制低速大于限制高速 返回错误
    public const int PU_RESULT_ITS_ERR_INVALID_NORMAL_SIGN_SPEED_CONFIG = 11133;//	小车标志速度不在低高速内 返回错误
    public const int PU_RESULT_ITS_ERR_INVALID_BIGVEHICLE_SPEED_RANGE_CONFIG = 11134;//	若大车低速大于高速 返回错误
    public const int PU_RESULT_ITS_ERR_INVALID_BIGVEHICLE_SIGN_SPEED_CONFIG = 11135;//	若大车标志速度不在低高速内 返回错误
    public const int PU_RESULT_ITS_ERR_INVALID_RETURNDATA = 11136;//	返回值无效
    public const int PU_RESULT_ITS_ERR_INVALID_CONGESTION_THRESHOLD = 11137;//	交通拥堵阈值无效
    public const int PU_RESULT_ITS_ERR_INVALID_SNAP_INTERVAL_TYPE = 11138;//	抓拍间隔类型无效
    public const int PU_RESULT_ITS_ERR_INVALID_ADAPT_SNAP_LOWSPEED = 11139;//	自适应抓拍间隔低速最大值无效
    public const int PU_RESULT_ITS_ERR_INVALID_ADAPT_SNAP_MIDSPEED = 11140;//	自适应抓拍间隔中速最大值无效
    public const int PU_RESULT_ITS_ERR_INVALID_ADAPT_LOWSPEED_INTERVAL = 11141;//	自适应低速抓拍间隔无效
    public const int PU_RESULT_ITS_ERR_INVALID_ADAPT_MIDSPEED_INTERVAL = 11142;//	自适应中速抓拍间隔无效
    public const int PU_RESULT_ITS_ERR_INVALID_ADAPT_HISPEED_INTERVAL = 11143;//	自适应高速抓拍间隔无效
    public const int PU_RESULT_ITS_ERR_INVALID_LANE_ORDER = 11144;//	设置失败，车道线、车道右边线请由左往右按序绘制
    public const int PU_RESULT_ITS_ERR_INVALID_LIGHT_CONFIGDUPLICATION = 11146;//	信号灯导向重复
    public const int PU_RESULT_ITS_ERR_INVALID_PRETESTLINE_LOCATION = 11147;//	前置线应绘制在停止线的下方

    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_LRPR = 12000;//	请先关闭车牌识别功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_FD = 12001;//	请先关闭人脸检测功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_CD = 12002;//	请先关闭停车侦测功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_VA = 12003;//	请先关闭行为分析功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_HC = 12004;//	请先关闭过线统计功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_AT = 12005;//	请先关闭自动跟踪功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_VHD = 12006;//	请先关闭机非人检测功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_ITS = 12007;//	请先关闭智能交通功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_QD = 12008;//	请先关闭排队检测功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_CDD = 12009;//	请先关闭人群密度功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_IBALL = 12010;//	请先关闭智能交通-违章球功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_VHDFACE = 12011;//	请先关闭一机多用功能
    public const int PU_RESULT_ITGT_MODE_NOTSUPPORT_ALG = 12012;//	当前模式下不支持该算法
    public const int PU_RESULT_TGT_VHD_DETECTION_ERR_WRONG_VIDEO_MODE = 12013;//	机非人不支持走廊模式，先关闭走廊模式
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_BEH = 12014;//	请先关闭增强模式行为分析功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_CAMPUS_TRAFFICEVENT = 12015;//	请先关闭出入口业务
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_CAMPUS_ALG_TYPE = 12016;//	出入口业务功能只支持国内车牌算法，不支持海外车牌算法
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_MD = 12017;//	请先关闭移动侦测功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_OD = 12018;//	请先关闭遮挡告警功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_SC = 12019;//	请先关闭场景变更功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_OOD = 12020;//	请先关闭虚焦检测功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_CA = 12021;//	请先关闭人员聚集功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_HM = 12022;//	请先关闭热度图功能
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_TRAFFICEVENT_CAMPUS = 12023;//	请先关闭全部车辆事件业务
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_TRAFFIC_STATISTIC_CAMPUS = 12024;//	请先关闭交通流量统计业务
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_VD = 12025;//	请先关闭视频质量诊断
    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_STABILIZER = 12026;//	请先关闭电子防抖业务

    public const int PU_RESULT_TGT_FUNCTION_MUTUAL_IMG_QUALITY_JUDGE = 12027;//	图像质量判断时请关闭所有其他业务

    public const int PU_RESULT_ITGT_ERR_FACE_SUCCESS = 12100;//	人脸导库成功
    public const int PU_RESULT_ITGT_ERR_FACEREC_DISABLE = 12101;//	人脸识别未使能
    public const int PU_RESULT_ITGT_ERR_DATA_UPDATE = 12102;//	数据更新失败
    public const int PU_RESULT_ITGT_ERR_OPREATION_NOTSUPPORT = 12103;//	操作不支持
    public const int PU_RESULT_ITGT_ERR_OPREATION_UNFINISHED = 12104;//	批量导库操作未完成
    public const int PU_RESULT_ITGT_ERR_FACELIB_OVERSIZE = 12105;//	底库个数超出上限
    public const int PU_RESULT_ITGT_ERR_FACENUM_OVERSIZE = 12106;//	人脸个数超出上限
    public const int PU_RESULT_ITGT_ERR_DB_ERROR = 12107;//	数据库操作失败
    public const int PU_RESULT_ITGT_ERR_FACELIST_REPAT = 12108;//	人脸库重复
    public const int PU_RESULT_ITGT_ERR_FACEPIC_OVERSIZE = 12109;//	图片宽高超范围
    public const int PU_RESULT_ITGT_ERR_FACE_DECODE = 12110;//	图片解码失败
    public const int PU_RESULT_ITGT_ERR_FACE_DETECTION = 12111;//	人脸检测失败
    public const int PU_RESULT_ITGT_ERR_FACE_FEATURE = 12112;//	人脸特征提取失败
    public const int PU_RESULT_ITGT_ERR_FACE_DAO = 12113;//	人脸持久化数据库失败
    public const int PU_RESULT_ITGT_ERR_FACE_FILE = 12114;//	人脸持写文件失败
    public const int PU_RESULT_ITGT_ERR_FACE_ALGDISABLE = 12115;//	人脸算法未开启
    public const int PU_RESULT_ITGT_ERR_FACE_NOFEATURE = 12116;//	人脸底库无特征
    public const int PU_RESULT_ITGT_ERR_FACE_UZIP = 12117;//	zip包解压失败
    public const int PU_RESULT_ITGT_ERR_FACE_CSV = 12118;//	csv文件解析失败
    public const int PU_RESULT_ITGT_ERR_FACE_ENCRYPT = 12119;//	face加解密失败
    public const int PU_RESULT_ITGT_ERR_FACE_TASKUNKNOW = 12120;//	任务未处理
    public const int PU_RESULT_ITGT_ERR_FEATURE_EXTRACT_SUCCESS = 12121;//	特征提取成功
    public const int PU_RESULT_ITGT_ERR_FEATURE_EXTRACTED = 12122;//	特征已提取
    public const int PU_RESULT_ITGT_ERR_FACEREC_ENABLE_FAIL = 12123;//	人脸识别使能失败，针对算法包不存在或版本不匹配的情况
    public const int PU_RESULT_ITGT_ERR_FACE_FEATURE_LOAD_PROCESSING = 12124;//	人脸识别存在历史布控，系统启动时需要加载特征
    public const int PU_RESULT_ITGT_ERR_FACE_FEATURE_PAC_IMPORT_PROCESSING = 12125;//	人脸导库正在导入特征包
    public const int PU_RESULT_ITGT_ERR_FACE_PIC_PAC_IMPORT_PROCESSING = 12126;//	人脸导库正在图片包导入
    public const int PU_RESULT_ITGT_ERR_FACE_FEATURE_GET_PROCESSING = 12127;//	人脸导库正在特征导出
    public const int PU_RESULT_ITGT_ERR_FACE_FEATURE_EXTRACT_PROCESSING = 12128;//	人脸导库正在特征提取
    public const int PU_RESULT_ITGT_ERR_EMMC_STATUS_ABNORMAL = 12132;//	EMMC状态异常
    public const int PU_RESULT_TGT_CAR_DATECTION_ERR_WRONG_VIDEO_MODE = 12200;//	停车检测打开时走廊模式和镜像模式必须关闭
    public const int PU_RESULT_ITGT_VHD_ERR_WRONG_VIDEO_MODE = 12201;//	机非人打开时走廊模式必须关闭
    public const int PU_RESULT_ITGT_VLPR_ERR_WRONG_VIDEO_MODE = 12202;//	车辆识别打开时走廊模式必须关闭
    public const int PU_RESULT_ITGT_NOT_FACE_DETETION_MODE_ERR_WRONG_VIDEO_MODE = 12203;//	-H款型非人卡模式时走廊模式必须关闭(混行、微卡、行为分析不支持)

    public const int PU_RESULT_LIC_INVALID = 12300;//	license非法，获取license内容失败
    public const int PU_RESULT_LIC_REPEATED_ESN_VER_MISMATCH = 12301;//	不允许重复加载 ESN 或版本不匹配的License文件
    public const int PU_RESULT_LIC_FORMAT_ERROR = 12302;//	License文件不合法
    public const int PU_RESULT_LIC_NO_PRD_FEATURES_PRESENT = 12303;//	License文件中没有产品特征段
    public const int PU_RESULT_LIC_PRODUCT_INVALID = 12304;//	产品名称无效
    public const int PU_RESULT_LIC_EXPIRED = 12305;//	License文件过期
    public const int PU_RESULT_LIC_GET_CONFIG_ERROR = 12306;//	获取控制项配置值失败
    public const int PU_RESULT_LIC_LSN_REVOKED = 12307;//	License文件已经失效
    public const int PU_RESULT_LIC_ESNANY_AND_SIX_MON_VLDITY_NOT_ALLOWED = 12308;//	不允许重复加载ESN=ANY且有效期为 6个月的调测License 文件
    public const int PU_RESULT_LIC_MAX_FEATURES_REACHED = 12309;//	License文件中Feature的数量超过最大值
    public const int PU_RESULT_LIC_INVALID_FEATURE_TYPE = 12310;//	License文件中Feature的类型错误
    public const int PU_RESULT_LIC_LM_NOT_ENABLED = 12311;//	License组件没有启动
    public const int PU_RESULT_LIC_NO_FEATURES_IN_NORMAL_STATE = 12312;//	License文件中所有的Feature过期或者处于试用期
    public const int PU_RESULT_LIC_ESN_MISMATCH = 12313;//	License文件ESN和实际ESN不一致
    public const int PU_RESULT_LIC_VERSION_MISMATCH = 12314;//	License文件版本和实际版本不一致
    public const int PU_RESULT_LIC_NO_LICENSE_ACTIVITED = 12315;//	没有激活的license
    public const int PU_RESULT_MTU_ERR_WITH_IPV6_OPEN = 12520;//	IPV6场景下MTU错误
    public const int PU_RESULT_ITGT_ERR_INVALID = 12600;//	智能license无效状态
    public const int PU_RESULT_MEDIA_UTGT_NOT_ENABLED = 12780;//	媒体创建智能通道，智能模块没有使能

    public const int PU_RESULT_TGT_SWITCH_MODE_ERR_WRONG_VIDEO_MODE = 12800;//	切换的模式不支持走廊模式
    public const int PU_RESULT_TGT_SWITCH_MODE_ERR_ENABLE_ALG = 12801;//	切换的模式算法启用失败，先检查模型
    public const int PU_RESULT_TGT_SWITCH_MODE_FTP_NEED_RECONFIG = 12802;//	切换模式成功，ftp需要重新配置
    public const int PU_RESULT_ODS_MOVE_DEVICE_NOT_INIT = 13250;//	未初始化动点
    public const int PU_RESULT_ODS_MOVE_DEVICE_ABNORMAL = 13251;//	动点异常
    public const int PU_RESULT_GET_ODS_MOVE_DEVICE_LOG_INFO_FAIL = 13252;//	获取动点日志失败
    public const int PU_RESULT_GET_ODS_MOVE_DEVICE_CONFIG_FAIL = 13253;//	获取动点配置文件失败
    public const int PU_RESULT_SET_ODS_MOVE_DEVICE_CONFIG_FAIL = 13254;//	设置动点配置文件失败
    public const int PU_RESULT_SET_ODS_MOVE_DEVICE_REBOOT_FAIL = 13255;//	动点重启失败
    public const int PU_RESULT_SET_ODS_MOVE_DEVICE_RESTORE_FAIL = 13256;//	动点恢复默认失败
    public const int PU_RESULT_ODS_SDK_FAIL = 13257;//	SDK内部错误
    public const int PU_RESULT_NEED_STOP_TRACK_ERR = 13258;//	跟踪开启状态，(1)无法标定(2)无法联动定位，提示先关闭跟踪
    public const int PU_RESULT_IN_CALIBRATING_ERR = 13259;//	正在标定中，无法标定，提示正在标定
    public const int PU_RESULT_NOT_CALIBRATING_ERR = 13260;//	未完成标定，(1)无法联动定位(2)无法开启跟踪，提示未完成标定，请先完成标定
    public const int PU_RESULT_NOT_IN_CALIBRATING_ERR = 13261;//	不在标定中，无需取消、查询进度，提示：未在标定进行中
    public const int PU_ERROR_MAX = 20000;//	预留值。

    #endregion

    /// <summary>
    /// 前端注册模式
    /// </summary>
    public enum PU_LINK_MODE_E
    {
        PU_AUTOLOGIN_MODE = 0,//自动注册模式
        PU_MANUALLOGIN_MODE = 1,//手动注册模式
        PU_BOTHLOGIN_MODE = 3,//混合注册模式
        PU_LINK_MODE_MAX//预留值
    }
    /// <summary>
    /// 设备事件回调类型
    /// </summary>
    public enum PU_EVENT_TYPE
    {
        PU_EVENT_TYPE_CONNCET = 1,
        PU_EVENT_TYPE_REGISTER = 2,
        PU_EVENT_TYPE_NOT_REGISTER = 3,
        PU_EVENT_TYPE_UNREGISTER = 4,
        PU_EVENT_TYPE_DISCONNECT = 5,
        PU_EVENT_TYPE_SEND_RECV_ERROR = 6,
        PU_EVENT_TYPE_KEEPLIVE_FAIL = 7,
        PU_EVENT_TYPE_STREAM_PACKAGE_CHANGE = 8,
        PU_EVENT_TYPE_WATERMARK_ERR = 9,
        PU_EVENT_TYPE_UPLOAD_IMAGE_URL = 10,
        PU_EVENT_TYPE_UPLOAD_IMAGE_COMP_NOTIFY = 11,
        PU_EVENT_TYPE_TRANSPARENT_CHANNEL_NOTIFY = 12,
        PU_EVENT_TYPE_REALPALY_ERROR = 13,
        PU_EVENT_TYPE_REPORT_VISUAL_INFO = 14,
        PU_EVENT_TYPE_PUPU_INFO = 15,
        PU_EVENT_TYPE_RECORD_COMP_NOTIFY = 16,
        PU_EVENT_TYPE_SLAVE_DEVICE_ADD = 17,
        PU_EVENT_TYPE_SLAVE_DEVICE_MODIFY = 18,
        PU_EVENT_TYPE_SLAVE_DEVICE_DELETE = 19,
        PU_EVENT_TYPE_SLAVE_DEVICE_ONLINE = 20,
        PU_EVENT_TYPE_SLAVE_DEVICE_OFFLINE = 21,
        PU_EVENT_TYPE_MAX = 23
    }
    /// <summary>
    /// 音视频编码类型
    /// </summary>
    public enum PU_ENCODE_TYPE_E
    {
        PU_ENC_PCMU = 0,
        PU_ENC_1016 = 1,
        PU_ENC_G721 = 2,
        PU_ENC_GSM = 3,
        PU_ENC_G723 = 4,
        PU_ENC_DVI4_8K = 5,
        PU_ENC_DVI4_16K = 6,
        PU_ENC_LPC = 7,
        PU_ENC_PCMA = 8,
        PU_ENC_G722 = 9,
        PU_ENC_S16BE_STEREO = 10,
        PU_ENC_S16BE_MONO = 11,
        PU_ENC_QCELP = 12,
        PU_ENC_CN = 13,
        PU_ENC_MPEGAUDIO = 14,
        PU_ENC_G728 = 15,
        PU_ENC_DVI4_3 = 16,
        PU_ENC_DVI4_4 = 17,
        PU_ENC_G729 = 18,
        PU_ENC_G711A = 19,
        PU_ENC_G711U = 20,
        PU_ENC_G726 = 21,
        PU_ENC_G729A = 22,
        PU_ENC_LPCM = 23,
        PU_ENC_CelB = 25,
        PU_ENC_JPEG = 26,
        PU_ENC_CUSM = 27,
        PU_ENC_NV = 28,
        PU_ENC_PICW = 29,
        PU_ENC_CPV = 30,
        PU_ENC_H261 = 31,
        PU_ENC_MPEGVIDEO = 32,
        PU_ENC_MPEG2TS = 33,
        PU_ENC_H263 = 34,
        PU_ENC_SPEG = 35,
        PU_ENC_MPEG2VIDEO = 36,
        PU_ENC_AAC = 37,
        PU_ENC_WMA9STD = 38,
        PU_ENC_HEAAC = 39,
        PU_ENC_PCM_VOICE = 40,
        PU_ENC_PCM_AUDIO = 41,
        PU_ENC_AACLC = 42,
        PU_ENC_MP3 = 43,
        PU_ENC_ADPCMA = 49,
        PU_ENC_AEC = 50,
        PU_ENC_X_LD = 95,
        PU_ENC_H264 = 96,
        PU_ENC_D_GSM_HR = 200,
        PU_ENC_D_GSM_EFR = 201,
        PU_ENC_D_L8 = 202,
        PU_ENC_D_RED = 203,
        PU_ENC_D_VDVI = 204,
        PU_ENC_D_BT656 = 220,
        PU_ENC_D_H263_1998 = 221,
        PU_ENC_D_MP1S = 222,
        PU_ENC_D_MP2P = 223,
        PU_ENC_D_BMPEG = 224,
        PU_ENC_MP4VIDEO = 230,
        PU_ENC_MP4AUDIO = 237,
        PU_ENC_VC1 = 238,
        PU_ENC_JVC_ASF = 255,
        PU_ENC_D_AVI = 256,
        PU_ENC_OPUS = 258,
        PU_ENC_H265 = 265,
        PU_ENC_AMR = 1001,
        PU_ENC_MJPEG = 1002,
        PU_ENC_MAX
    }
    /// <summary>
    /// 视频分辨率类型
    /// </summary>
    public enum PU_RESOLUTION_TYPE_E
    {
        PU_RESOLUTION_480I = 0,
        PU_RESOLUTION_576I,
        PU_RESOLUTION_QCIF_PAL,
        PU_RESOLUTION_QCIF_NTSC,
        PU_RESOLUTION_CIF_PAL,
        PU_RESOLUTION_CIF_NTSC,
        PU_RESOLUTION_2CIF,
        PU_RESOLUTION_HD1,
        PU_RESOLUTION_D1_PAL,
        PU_RESOLUTION_D1_NTSC,
        PU_RESOLUTION_QVGA,
        PU_RESOLUTION_VGA,
        PU_RESOLUTION_XGA,
        PU_RESOLUTION_SXGA,
        PU_RESOLUTION_UXGA,
        PU_RESOLUTION_QXGA,
        PU_RESOLUTION_WVGA,
        PU_RESOLUTION_WSXGA,
        PU_RESOLUTION_WUXGA,
        PU_RESOLUTION_WQXGA,
        PU_RESOLUTION_HD720,
        PU_RESOLUTION_HD1080,
        PU_RESOLUTION_HD1080I,
        PU_RESOLUTION_HD960,
        PU_RESOLUTION_HD1024,
        PU_RESOLUTION_HD1296P = 25,
        PU_RESOLUTION_HD1440P = 26,
        PU_RESOLUTION_HD1728P = 27,
        PU_RESOLUTION_HD4K = 28,
        PU_RESOLUTION_HD1536P = 29,
        PU_RESOLUTION_HD1920P = 30,
        PU_RESOLUTION_HD1944P = 31,
        PU_RESOLUTION_HD2448P = 32,
        PU_RESOLUTION_HD2160P = 33,
        PU_RESOLUTION_HD2736P = 34,
        PU_RESOLUTION_MAX
    }
    /// <summary>
    /// 视频流模式
    /// </summary>
    public enum PU_STREAM_MODE_E
    {
        PU_VIEDO_STREAM_NONE = 0,
        PU_VIEDO_STREAM_SINGLE = 1,
        PU_VIEDO_STREAM_DOUBLE = 2,
        PU_VIEDO_STREAM_TRIPLE = 3,
        PU_VIEDO_STREAM_FOUR = 4,
        PU_VIEDO_STREAM_FIVE = 5,
        PU_VIEDO_STREAM_MAX
    }
    /// <summary>
    /// 视频流类型
    /// </summary>
    public enum PU_STREAM_TYPE_E
    {
        PU_VIDEO_MAIN_STREAM = 0,
        PU_VIDEO_SUB_STREAM1,
        PU_VIDEO_SUB_STREAM2,
        PU_VIDEO_SUB_STREAM3,
        PU_VIDEO_SUB_STREAM4,
        PU_VIDEO_SUB_STREAM5,
        PU_VIDEO_STREAM_MAX
    }
    /// <summary>
    /// 图像质量
    /// </summary>
    public enum PU_PIC_QUALITY_E
    {
        PU_PIC_QUALITY_BEST = 0,
        PU_PIC_QUALITY_MORE_BETTER,
        PU_PIC_QUALITY_BETTER,
        PU_PIC_QUALITY_ORDINARY,
        PU_PIC_QUALITY_BAD,
        PU_PIC_QUALITY_BADEST,
        PU_PIC_QUALITY_MAX
    }
    /// <summary>
    /// 数据传输类型
    /// </summary>
    public enum PU_PROTOCOL_TYPE_E
    {
        PU_PROTOCOL_TYPE_UDP = 0,
        PU_PROTOCOL_TYPE_TCP,
        PU_PROTOCOL_TYPE_MAX
    }

    /// <summary>
    /// 媒体回调类型
    /// </summary>
    public enum PU_MEDIA_CALLBACK_TYPE_E
    {
        PU_MEDIA_CALLBACK_TYPE_RTP = 0,
        PU_MEDIA_CALLBACK_TYPE_RTP_CRYPTO,
        PU_MEDIA_CALLBACK_TYPE_FRAME,
        PU_MEDIA_CALLBACK_TYPE_YUV,
        PU_MEDIA_CALLBACK_TYPE_FOR_STORAGE,
        PU_MEDIA_CALLBACK_TYPE_META_FRAME,
        PU_MEDIA_CALLBACK_TYPE_MAX
    }
    /// <summary>
    /// 码流类型
    /// </summary>
    public enum PU_VIDEO_TYPE_E
    {
        PU_VIDEO_TYPE_VIDEO = 0,
        PU_VIDEO_TYPE_AUDIO,
        PU_VIDEO_TYPE_MUX,
        PU_VIDEO_TYPE_RECORD,
        PU_VIDEO_TYPE_META,
        PU_VIDEO_TYPE_VIDEO_META,
        PU_VIDEO_TYPE_MAX
    }
    /// <summary>
    /// 媒体加密类型
    /// </summary>
    public enum PU_MEDIA_CRYPTO_TYPE_E
    {
        PU_MEDIA_CRYPTO_NONE = 0,
        PU_MEDIA_CRYPTO_HW_SIMPLE = 1,
        PU_MEDIA_CRYPTO_AES_128BIT = 2,
        PU_MEDIA_CRYPTO_AES_192BIT = 3,
        PU_MEDIA_CRYPTO_AES_256BIT = 4,
        PU_MEDIA_CRYPTO_AES256_CBC = 5,
        PU_MEDIA_CRYPTO_MAX
    }
    /// <summary>
    /// 码率类型
    /// </summary>
    public enum PU_BITRATE_TYPE_E
    {
        PU_BIT_RATE_TYPE_FIXED = 0,
        PU_BIT_RATE_TYPE_VARIABLE,
        PU_BIT_RATE_TYPE_MAX
    }
    /// <summary>
    /// 视频制式
    /// </summary>
    public enum PU_VIDEO_FORMAT_E
    {
        PU_VIDEO_FORMAT_PAL = 0,
        PU_VIDEO_FORMAT_NTSC,
        PU_VIDEO_FORMAT_UNKNOWN
    }
    /// <summary>
    /// 帧率优先码率优先
    /// </summary>
    public enum PU_H264_RC_PRI_E
    {
        PU_H264_RC_FRAMERATE_PRI = 1,
        PU_H264_RC_BITRATE_PRI,
        PU_H264_RC_PRI_MAX
    }
    /// <summary>
    /// 语言类型
    /// </summary>
    public enum PU_LANGUAGE_TYPE_E
    {
        PU_LANGUAGE_TYPE_CHINESE = 0,
        PU_LANGUAGE_TYPE_ENGLISH,
        PU_LANGUAGE_TYPE_MAX
    }
    /// <summary>
    /// 本地保存录像方式
    /// </summary>
    public enum PU_SAVE_REALDATA_TYPE_E
    {
        PU_SAVE_REALDATA_TYPE_TIME = 0,
        PU_SAVE_REALDATA_TYPE_SIZE = 1,
        PU_SAVE_REALDATA_TYPE_MAX
    }
    /// <summary>
    /// 本地保存图片方式
    /// </summary>
    public enum PU_SAVE_PICTURE_TYPE_E
    {
        PU_SAVE_PICTURE_TYPE_BMP = 0,
        PU_SAVE_PICTURE_TYPE_JEPG = 1,
        PU_SAVE_PICTURE_TYPE_MAX
    }
    /// <summary>
    /// 串口类型
    /// </summary>
    public enum PU_SERIAL_PORT_MODE_E
    {
        PU_SERIAL_PORT_RS232 = 0,
        PU_SERIAL_PORT_RS422,
        PU_SERIAL_PORT_RS485,
        PU_SERIAL_PORT_MAX
    }
    /// <summary>
    /// 波特率
    /// </summary>
    public enum PU_BAUD_RATE_E
    {
        PU_BAUD_R2400 = 0,
        PU_BAUD_R4800,
        PU_BAUD_R9600,
        PU_BAUD_R19200,
        PU_BAUD_R38400,
        PU_BAUD_R57600,
        PU_BAUD_R115200,
        PU_BAUD_R230400,
        PU_BAUD_R460800,
        PU_BAUD_R921600,
        PU_BAUD_MAX
    }
    /// <summary>
    /// 数据位
    /// </summary>
    public enum PU_DATA_BIT_E
    {
        PU_DATA_BIT_CS5 = 0,
        PU_DATA_BIT_CS6,
        PU_DATA_BIT_CS7,
        PU_DATA_BIT_CS8,
        PU_DATA_BIT_MAX
    }
    /// <summary>
    /// 校验位
    /// </summary>
    public enum PU_PARITY_BIT_E
    {
        PU_PARITY_BIT_NONE = 0,
        PU_PARITY_BIT_ODD,
        PU_PARITY_BIT_EVEN,
        PU_PARITY_BIT_MARK,
        PU_PARITY_BIT_SPACE,
        PU_PARITY_BIT_MAX
    }
    /// <summary>
    /// 停止位
    /// </summary>
    public enum PU_STOP_BIT_E
    {
        PU_STOP_BIT_OFF = 0,
        PU_STOP_BIT_ON,
        PU_STOP_BIT_MAX
    }
    /// <summary>
    /// 串口流控制类型
    /// </summary>
    public enum PU_FLOW_CONTROL_E
    {
        PU_FLOW_CONTROL_NONE = 0,
        PU_FLOW_CONTROL_SOFT,
        PU_FLOW_CONTROL_HARD,
        PU_FLOW_CONTROL_MAX
    }
    /// <summary>
    /// 云台解码器类型
    /// </summary>
    public enum PU_PTZ_DECODER_TYPE_E
    {
        PU_PTZ_DECODER_PELCO_P = 1,
        PU_PTZ_DECODER_PELCO_D,
        PU_PTZ_DECODER_YAAN,
        PU_PTZ_DECODER_SAMSUNG,
        PU_PTZ_DECODER_REDAPPLE_5052,
        PU_PTZ_DECODER_TAISHUO,
        PU_PTZ_DECODER_REDAPPLE_5051,
        PU_PTZ_DECODER_USER_DEF,
        PU_PTZ_DECODER_MAX
    }
    /// <summary>
    /// 正反向控制
    /// </summary>
    public enum PU_PTZ_CONTROL_MODE_E
    {
        PU_PTZ_CONTROL_MODE_FORWARD = 1,
        PU_PTZ_CONTROL_MODE_BACK,
        PU_PTZ_CONTROL_MODE_MAX
    }

    /// <summary>
    /// 告警发生状态
    /// </summary>
    public enum PU_ALARM_ACTION_E
    {
        PU_ALARM_ACTION_MOVE = 1,
        PU_ALARM_ACTION_HAPPEN
    }
    /// <summary>
    /// 云台控制操作码
    /// </summary>
    public enum PU_PTZ_OPCODE_E
    {
        PU_PTZ_STOP = 1,
        PU_PTZ_UP = 2,
        PU_PTZ_DOWN = 3,
        PU_PTZ_LEFT = 4,
        PU_PTZ_UP_LEFT = 5,
        PU_PTZ_DOWN_LEFT = 6,
        PU_PTZ_RIGHT = 7,
        PU_PTZ_UP_RIGHT = 8,
        PU_PTZ_DOWN_RIGHT = 9,
        PU_PTZ_AUTO = 10,
        PU_PTZ_PRESET_RUN = 11,
        PU_PTZ_CRUISE_RUN = 12,
        PU_PTZ_CRUISE_STOP = 13,
        PU_PTZ_MENU_OPEN = 14,
        PU_PTZ_MENU_EXIT = 15,
        PU_PTZ_MENU_ENTER = 16,
        PU_PTZ_FLIP = 17,
        PU_PTZ_HOMING = 18,
        PU_PTZ_LENS_APERTURE_OPEN = 19,
        PU_PTZ_LENS_APERTURE_CLOSE = 20,
        PU_PTZ_LENS_ZOOM_WIDE = 21,
        PU_PTZ_LENS_ZOOM_TELESCOPE = 22,
        PU_PTZ_LENS_ZOOM_STOP = 23,
        PU_PTZ_LENS_FOCAL_NEAR = 24,
        PU_PTZ_LENS_FOCAL_FAR = 25,
        PU_PTZ_LENS_FOCAL_STOP = 26,
        PU_PTZ_AUX_OPEN = 27,
        PU_PTZ_AUX_STOP = 28,
        PU_PTZ_HORIZONTAL_SCAN = 29,
        PU_PTZ_VERTICAL_SCAN = 30,
        PU_PTZ_MODE_SET_START = 31,
        PU_PTZ_MODE_SET_STOP = 32,
        PU_PTZ_FAST_LOCATE = 33,
        PU_PTZ_REBOOT = 35,
        PU_PTZ_RESTORE = 36,
        PU_PTZ_SET_LEFT_LIMIT = 37,
        PU_PTZ_SET_RIGHT_LIMIT = 38,
        PU_PTZ_MODE_CRUISE_START = 39,
        PU_PTZ_MODE_CRUISE_STOP = 40,
        PU_PTZ_FAST_MOVE = 41,
        PU_PTZ_HORIZONTAL_LIMIT_SCAN = 51,
        PU_PTZ_LENS_AUTO_FOCAL = 52,
        PU_PTZ_GOTO_HOME = 53,
        PU_PTZ_ONE_PUSH = 54,
        PTZ_VERTICAL_LIMIT_SCAN = 55,
        PTZ_SET_UP_LIMIT = 56,
        PTZ_SET_DOWN_LIMIT = 57,
        PTZ_CMD_MAX
    }
    /// <summary>
    /// 云台运动模式
    /// </summary>
    public enum PU_PTZ_MOTION_MODE_E
    {
        PU_PTZ_MOTION_MODE_BURST = 1,
        PU_PTZ_MOTION_MODE_CONTINUOUS,
        PU_PTZ_MOTION_MODE_MAX
    }

    /// <summary>
    /// 云台预置位操作命令字
    /// </summary>
    public enum PU_PTZ_PRESET_CMD_E
    {
        PU_PTZ_PRESET_SET = 1,
        PU_PTZ_PRESET_GET,
        PU_PTZ_PRESET_CLR,
        PU_PTZ_PRESET_GOTO,
        PU_PTZ_PRESET_MAX
    }
    /// <summary>
    /// 巡航轨迹操作命令字
    /// </summary>
    public enum PU_PTZ_CRUISE_TRACK_E
    {
        PU_PTZ_CRUISE_TRACK_SET = 1,
        PU_PTZ_CRUISE_TRACK_GET,
        PU_PTZ_CRUISE_TRACK_CLR,
        PU_PTZ_CRUISE_TRACK_GOTO,
        PU_PTZ_CRUISE_TRACK_STOP,
        PU_PTZ_CRUISE_TRACK_MAX
    }
    /// <summary>
    /// OSD日期格式
    /// </summary>
    public enum PU_OSD_DATE_TYPE_E
    {
        PU_YYYY_MM_DD = 0,
        PU_MM_DD_YYYY,
        PU_YYYY_MM_DD_CH,
        PU_MM_DD_YYYY_CH,
        PU_DD_MM_YYYY,
        PU_DD_MM_YYY_CH,
        PU_DATE_TYPE_MAX
    }
    /// <summary>
    /// 告警类型
    /// </summary>
    public enum PU_ALARM_TYPE_E
    {
        PU_ALARM_TYPE_DI = 1,
        PU_ALARM_TYPE_DISK_FULL,
        PU_ALARM_TYPE_NO_SIGNAL,
        PU_ALARM_TYPE_MOVE_DECTION,
        PU_ALARM_TYPE_DISK_FAULT,
        PU_ALARM_TYPE_SHIELD,
        PU_ALARM_TYPE_NETWORK_INTERRUPT,
        PU_ALARM_TYPE_IP_ADDRESS_CONFLICT,
        PU_ALARM_TYPE_TEMPERATURE,
        PU_ALARM_TYPE_FACE_DETECTION,
        PU_ALARM_TYPE_INVADE,
        PU_ALARM_TYPE_COUNT,
        PU_ALARM_TYPE_DISTURB,
        PU_ALARM_TYPE_TRIPWIRE = 14,
        PU_ALARM_TYPE_INTRUSION = 15,
        PU_ALARM_TYPE_HOVER = 16,
        PU_ALARM_TYPE_LEGACY = 17,
        PU_ALARM_TYPE_REMOVE = 18,
        PU_ALARM_TYPE_DISK_EXCEPTION = 31,
        PU_ALARM_TYPE_AUDIO_EXCEPTION = 32,
        PU_ALARM_TYPE_STORAGE_FAIL,
        PU_ALARM_TYPE_FAN_PWR_BLOCKED = 38,
        PU_ALARM_TYPE_FAN_HEC_BLOCKED,
        PU_ALARM_TYPE_SFP_TEMP_HIGH,
        PU_ALARM_TYPE_SFP_TEMP_LOW,
        PU_ALARM_TYPE_SFP_VOL_HIGH,
        PU_ALARM_TYPE_SFP_VOL_LOW,
        PU_ALARM_TYPE_SFP_BIAS_HIGH,
        PU_ALARM_TYPE_SFP_BIAS_LOW,
        PU_ALARM_TYPE_SFP_TX_PWR_HIGH,
        PU_ALARM_TYPE_SFP_TX_PWR_LOW,
        PU_ALARM_TYPE_SFP_RX_PWR_HIGH,
        PU_ALARM_TYPE_SFP_RX_PWR_LOW,
        PU_ALARM_TYPE_SFP_LASER_TEMP_HIGH,
        PU_ALARM_TYPE_SFP_LASER_TEMP_LOW,
        PU_ALARM_TYPE_SFP_TEC_CURRENT_HIGH,
        PU_ALARM_TYPE_SFP_TEC_CURRENT_LOW,
        PU_ALARM_TYPE_DISC_PULLOUT,
        PU_ALARM_TYPE_LIGHT_SENSOR_INCVALID,
        PU_ALARM_TYPE_EXTERNAL_POWER_DOWN,
        PU_ALARM_TYPE_WIPER_FAILURE_ALARM,
        PU_ALARM_TYPE_SFP_NOT_EXIST,
        PU_ALARM_TYPE_TYPE_PTOPT_HOR_FAIL,
        PU_ALARM_TYPE_TYPE_PTOPT_VER_FAIL,
        PU_ALARM_TYPE_ITS_RADAR_EXCEPTION_ALARM = 62,
        PU_ALARM_TYPE_ITS_IOCOIL_EXCEPTION_ALARM,
        PU_ALARM_TYPE_ITS_485COIL_EXCEPTION_ALARM,
        PU_ALARM_TYPE_ITS_REDTOR_EXCEPTION_ALARM,
        PU_ALARM_TYPE_LENS_FAILURE_ALARM,
        PU_ALARM_TYPE_AUDIO_UP = 100,
        PU_ALARM_TYPE_AUDIO_DOWN,
        PU_ALARM_TYPE_ENTER,
        PU_ALARM_TYPE_EXIT,
        PU_ALARM_TYPE_FASTMOVE,
        PU_ALARM_TYPE_CPU_HIGHT,
        PU_ALARM_TYPE_MEM_HIGHT,
        PU_ALARM_TYPE_SCENECHANGE = 107,
        PU_ALARM_TYPE_AUTOTRACKING,
        PU_ALARM_TYPE_OUTOFFOCUS_DETECT,
        PU_ALARM_TYPE_CROWD_ANALYSIS,
        PU_ALARM_TYPE_SHAKE_DIAGNOSIS,
        PU_ALARM_TYPE_FROZEN_DIAGNOSIS,
        PU_ALARM_TYPE_SNOW_NOISE_DIAGNOSIS,
        PU_ALARM_TYPE_STRIPENOISE_DIAGNOSIS,
        PU_ALARM_TYPE_BRIGHT_DIAGNOSIS,
        PU_ALARM_TYPE_COLORCAST_DIAGNOSIS,
        PU_ALARM_TYPE_CAR_DETECTION,
        PU_ALARM_TYPE_HUMAN_COUNT,
        PU_ALARM_TYPE_FD_DL,
        PU_ALARM_TYPE_QUEUE_DETECT = 121,
        PU_ALARM_TYPE_CROWD_DENSITY_DETECT,
        PU_ALARM_TYPE_ILLEGAL_PARKING,
        PU_ALARM_TYPE_VLPR_TRAFFIC_CONGESTION,
        PU_ALARM_TYPE_TRAFFIC_CONGESTION,
        PU_ALARM_TYPE_FACE_RECOGNITION,
        PU_LPR_CAPTURE_RES = 200,
        PU_MANUAL_LPR_CAPTURE_RES = 201,
        PU_ALARM_TYPE_HTTPS_CERT_EXPIRE = 300,
        PU_ALARM_TYPE_HTTPS_CERT_WILL_EXPIRE,
        PU_ALARM_TYPE_DOT1X_CERT_EXPIRE,
        PU_ALARM_TYPE_DOT1X_CERT_WILL_EXPIRE,
        PU_ALARM_TYPE_SDK_PWD_STILL_INITIAL_PWD,
        PU_ALARM_TYPE_SSH_OPEN = 306,
        PU_ALARM_TYPE_SDK_USR_LOCK = 307,
        PU_ALARM_TYPE_WEB_USR_LOCK = 308,
        PU_ALARM_TYPE_ONVIF_USR_LOCK = 309,
        PU_ALARM_TYPE_GENETEC_USR_LOCK = 310,
        PU_ALARM_TYPE_DOT1X_CA_CERT_EXPIRE,
        PU_ALARM_TYPE_DOT1X_CA_CERT_WILL_EXPIRE,
        PU_ALARM_TYPE_WEB_PWD_EXPIRE = 314,
        PU_ALARM_TYPE_VE_ILLEGAL_PARKING = 400,
        PU_ALARM_TYPE_VE_ON_VEHICLE_LANE,
        PU_ALARM_TYPE_VE_ON_NONEVEHICLE_LANE,
        PU_ALARM_TYPE_VE_PRESSING_LINE,
        PU_ALARM_TYPE_VE_WRONG_DIRECTION,
        //PU_ALARM_TYPE_VE_ABNORMAL_PLATE,   
        PU_ALARM_TYPE_VE_REVERSE = 406,
        //多机互助
        PU_ALARM_TYPE_SLAVE_RTSP_KEEP_ALIVE_FAIL = 500, //从机rtsp保活失败    
        PU_ALARM_TYPE_SLAVE_STREAM_NORMAL = 506,        //从机rtsp流正常    
        PU_ALARM_TYPE_WIFI_ALARM = 550,                 //wifi异常    
        PU_ALARM_TYPE_UPDATE_ROLLBACK_ALARM = 560,      //升级版本失败回退告警    
        PU_ALARM_TYPE_ALL,
        PU_ALARM_TYPE_MAX
    }
    /// <summary>
    /// 平台类型
    /// </summary>
    public enum PU_PLATFORM_TYPE_E
    {
        PU_PLATFORM_TYPE_NVS = 1,
        PU_PLATFORM_TYPE_IVS = 2,
        PU_PLATFORM_TYPE_GBT,
        PU_PLATFORM_TYPE_IVS_ENABLE,
        PU_PLATFORM_TYPE_GBT_ENABLE,
        PU_PLATFORM_TYPE_SDK_ENABLE,
        PU_PLATFORM_TYPE_OTHERS
    }
    /// <summary>
    /// SDK平台类型
    /// </summary>
    public enum PU_SDK_PLATFORM_MODE_E
    {
        PU_SDK_PALTFORM_MODE_SINGEL = 1,
        PU_SDK_PLATFORM_MODE_DUAL,
        PU_SDK_PLATFORM_MODE_MAX
    }
    /// <summary>
    /// 网络连接类型
    /// </summary>
    public enum PU_CONNECT_TYPE_E
    {
        PU_CONNECT_TYPE_PWD = 0,
        PU_CONNECT_TYPE_SSL_PWD,
        PU_CONNECT_TYPE_MAX
    }
    /// <summary>
    /// 日志类型
    /// </summary>
    public enum PU_LOG_TYPE_E
    {
        PU_LOG_TYPE_OPERATION = 1,
        PU_LOG_TYPE_EXCEPT,
        PU_LOG_TYPE_ALARM,
        PU_LOG_TYPE_HARD_ALARM,
        PU_LOG_TYPE_SOFTWAREINFO,
        PU_LOG_TYPE_MAX
    }
    /// <summary>
    /// 日志打印开关
    /// </summary>
    public enum SDK_LOG_FLAG
    {
        LOG_PRINT_OPEN_ERROR = 0,
        LOG_PRINT_OPEN_WARNING = 1,
        LOG_PRINT_OPEN_DEBUG = 2,
        LOG_PRINT_DISABLE = 3,
        LOG_PRINT_MAX
    }
    /// <summary>
    /// 分辨率模式
    /// </summary>
    public enum PU_DISRESOLUTION_MODE_E
    {
        PU_VGA_NOT_AVALIABLE,
        PU_VGA_MODE_SVGA_60HZ = 1,
        PU_VGA_MODE_SVGA_75HZ,
        PU_VGA_MODE_XGA_60HZ,
        PU_VGA_MODE_XGA_70HZ,
        PU_VGA_MODE_SXGA_60HZ,
        PU_VGA_MODE_720P_60HZ,
        PU_VGA_MODE_1080i_60HZ,
        PU_VGA_MODE_1080P_30HZ,
        PU_VGA_MODE_UXGA_30HZ,
        PU_HDMI_MODE_XGA_60HZ = 21,
        PU_HDMI_MODE_SXGA_60HZ,
        PU_HDMI_MODE_SXGA2_60HZ,
        PU_HDMI_MODE_720P_60HZ,
        PU_HDMI_MODE_720P_50HZ,
        PU_HDMI_MODE_1080I_60HZ,
        PU_HDMI_MODE_1080I_50HZ,
        PU_HDMI_MODE_1080P_25HZ,
        PU_HDMI_MODE_1080P_30HZ,
        PU_HDMI_MODE_1080P_50HZ,
        PU_HDMI_MODE_1080P_60HZ,
        PU_HDMI_MODE_UXGA_60HZ,
        PU_DVI_MODE_XGA_60HZ = 41,
        PU_DVI_MODE_SXGA_60HZ,
        PU_DVI_MODE_SXGA2_60HZ,
        PU_DVI_MODE_720P_60HZ,
        PU_DVI_MODE_720P_50HZ,
        PU_DVI_MODE_1080I_60HZ,
        PU_DVI_MODE_1080I_50HZ,
        PU_DVI_MODE_1080P_25HZ,
        PU_DVI_MODE_1080P_30HZ,
        PU_DVI_MODE_1080P_50HZ,
        PU_DVI_MODE_1080P_60HZ,
        PU_DVI_MODE_UXGA_60HZ,
        PU_BNC_MODE_D1PAL_60HZ = 61,
        PU_BNC_MODE_D1PAL_50HZ,
        PU_BNC_MODE_D1NTSC_60HZ,
        PU_BNC_MODE_D1NTSC_50HZ,
        PU_DISRESOLUTION_MODE_MAX
    }
    /// <summary>
    /// 端口类型
    /// </summary>
    public enum PU_PORT_TYPE_E
    {
        PU_PORT_TYPE_HDMI = 0,
        PU_PORT_TYPE_VGA = 1,
        PU_PORT_TYPE_BNC = 2,
        PU_PORT_TYPE_DVI = 3,
        PU_PORT_TYPE_MAX
    }
    /// <summary>
    /// 端口模式
    /// </summary>
    public enum PU_PORT_MODE_E
    {
        PU_PORT_MODE_1 = 1,
        PU_PORT_MODE_2 = 2,
        PU_PORT_MODE_4 = 4,
        PU_PORT_MODE_9 = 9,
        PU_PORT_MODE_16 = 16,
        PU_PORT_MODE_MAX
    }
    /// <summary>
    /// 解码器输出帧率
    /// </summary>
    public enum PU_FRAME_RATE_E
    {
        PU_FRAME_RATE_30 = 0,
        PU_FRAME_RATE_50,
        PU_FRAME_RATE_60
    }
    /// <summary>
    /// 码流加密类型
    /// </summary>
    public enum PU_ENCRYPT_TYPE_E
    {
        PU_ENCRYPT_TYPE_HUAWEI_VIDEO = 0,
        PU_ENCRYPT_TYPE_HUAWEI_AUDIO,
        PU_ENCRYPT_TYPE_HUAWEI_MUX,
        PU_ENCRYPT_TYPE_NONE,
        PU_ENCRYPT_TYPE_MAX
    }
    /// <summary>
    /// 音频端口类型
    /// </summary>
    public enum PU_AUDIO_PORT_TYPE_E
    {
        PU_AUDIO_PORT_TYPE_BNC_PLAY = 0,
        PU_AUDIO_PORT_TYPE_HDMI_PLAY = 1,
        PU_AUDIO_PORT_TYPE_MAX
    }
    /// <summary>
    /// 音频采样率
    /// </summary>
    public enum PU_AUDIO_SAMPLERATE_E
    {
        PU_AUDIO_SAMPLERATE_8000 = 8000,
        PU_AUDIO_SAMPLERATE_12000 = 12000,
        PU_AUDIO_SAMPLERATE_11025 = 11025,
        PU_AUDIO_SAMPLERATE_16000 = 16000,
        PU_AUDIO_SAMPLERATE_22050 = 22050,
        PU_AUDIO_SAMPLERATE_24000 = 24000,
        PU_AUDIO_SAMPLERATE_32000 = 32000,
        PU_AUDIO_SAMPLERATE_44100 = 44100,
        PU_AUDIO_SAMPLERATE_48000 = 48000,
        PU_AUDIO_SAMPLERATE_MAX
    }
    /// <summary>
    /// G726编码格式的码率
    /// </summary>
    public enum PU_AUDIO_G726_BPS_E
    {
        PU_AUDIO_G726_16K = 0,
        PU_AUDIO_G726_24K,
        PU_AUDIO_G726_32K,
        PU_AUDIO_G726_40K,
        PU_AUDIO_G726_64K,
        PU_AUDIO_G726_96K,
        PU_AUDIO_G726_128K,
        PU_AUDIO_G726_160K,
        PU_AUDIO_G726_192K,
        PU_AUDIO_G726_224K,
        PU_AUDIO_G726_256K,
        PU_AUDIO_G726_288K,
        PU_AUDIO_G726_320K,
        PU_AUDIO_G726_352K,
        PU_AUDIO_G726_384K,
        PU_AUDIO_G726_416K,
        PU_AUDIO_G726_448K,
        PU_AUDIO_G726_480K,
        PU_AUDIO_G726_512K,
        PU_AUDIO_G726_48K,
        PU_AUDIO_G726_22K,
        PU_AUDIO_G726_MAX,
    }
    /// <summary>
    /// 视频昼夜模式
    /// </summary>
    public enum PU_VIDEO_DAYNIGHT_MODE_E
    {
        PU_VIDEO_DAYNIGHT_MODE_AUTO = 0,
        PU_VIDEO_DAYNIGHT_MODE_COLOR,
        PU_VIDEO_DAYNIGHT_MODE_GRAY,
        PU_VIDEO_DAYNIGHT_MODE_MAX
    }
    /// <summary>
    /// 图像镜像模式
    /// </summary>
    public enum PU_VIDEO_MIRROR_MODE_E
    {
        PU_VIDEO_MIRROR_MODE_NORMAL = 0,
        PU_VIDEO_MIRROR_MODE_MIRROR,
        PU_VIDEO_MIRROR_MODE_FLIP,
        PU_VIDEO_MIRROR_MODE_BOTH,
        PU_VIDEO_MIRROR_MODE_MAX
    }
    /// <summary>
    /// 背景频率
    /// </summary>
    public enum PU_VIDEO_FLICKER_MODE_E
    {
        PU_VIDEO_FLICKER_NONE = 0,
        PU_VIDEO_FLICKER_50HZ,
        PU_VIDEO_FLICKER_60HZ,
        PU_VIDEO_FLICKER_MAX
    }
    /// <summary>
    /// 测光模式
    /// </summary>
    public enum PU_VIDEO_AEMETERING_MODE_E
    {
        PU_VIDEO_AEMETERING_CENTER = 0,
        PU_VIDEO_AEMETERING_SPOT,
        PU_VIDEO_AEMETERING_AVERAGE,
        PU_VIDEO_AEMETERING_BACKLIGHT,
        PU_VIDEO_AEMETERING_CLOSE,
        PU_VIDEO_AEMETERING_USER,
        PU_VIDEO_AEMETERING_MAX
    }
    /// <summary>
    /// AE曝光模式
    /// </summary>
    public enum PU_AE_MODE_E
    {
        PU_AE_MODE_AUTO = 0,
        PU_AE_MODE_MANUAL,
        PU_AE_MODE_SHUTTER_PRI,
        PU_AE_MODE_IRIS_PRI,
        PU_AE_MODE_LOW_NOISE,
        PU_AE_MODE_FRAME_RATE,
        PU_AE_MODE_BRIGHT,
        PU_AE_MODE_MAX
    }
    /// <summary>
    /// 宽动态模式
    /// </summary>
    public enum PU_WDR_SWITCH_MODE_E
    {
        PU_WDR_SWITCH_AUTO,
        PU_WDR_SWITCH_CLOSE,
        PU_WDR_SWITCH_MANUAL,
        PU_WDR_SWITCH_MAX,
    }
    /// <summary>
    /// 抓拍类型
    /// </summary>
    public enum PU_SNAPSHOT_TYPE_E
    {
        PU_SNAPSHOT_TYPE_MANUAL = 0,
        PU_SNAPSHOT_TYPE_ALARM,
        PU_SNAPSHOT_TYPE_TIMER,
        PU_SNAPSHOT_TYPE_MANUAL_EX,
        PU_SNAPSHOT_TYPE_FACEDT,
        PU_SNAPSHOT_TYPE_ITGT,
        PU_SNAPSHOT_TYPE_ITS,
        PU_SNAPSHOT_TYPE_VEHICLE,
        PU_SNAPSHOT_TYPE_MAX
    }
    /// <summary>
    /// 图像质量判定的图片类型
    /// </summary>
    public enum PU_IMG_QUALITY_JUDGE_TYPE_E
    {
        PU_FACE_IMG,
        PU_MV_ATGATE_IMG,
    }
    /// <summary>
    /// 业务类型
    /// </summary>
    public enum PU_BUSINESS_TYPE_E
    {
        PU_BUSINESS_REAL_VIDEO = 0,
        PU_BUSINESS_AUDIO_TALK,
        PU_BUSINESS_AUDIO_BROADCAST,
        PU_BUSINESS_RECORD_DOWNLOAD,
        PU_BUSINESS_RECORD_PLAY_BACK,
        PU_BUSINESS_SNAPSHOT_DOWNLOAD,
        PU_BUSINESS_TYPE_MAX
    }
    /// <summary>
    /// 视频流的传输类型
    /// </summary>
    public enum PU_VIDEO_CODE_TYPE_E
    {
        PU_VIDEO_CODE_TYPE_ES,
        PU_VIDEO_CODE_TYPE_PS,
        PU_VIDEO_CODE_TYPE_TS,
        PU_VIDEO_CODE_TYPE_MAX
    }
    /// <summary>
    /// 录像类型
    /// </summary>
    public enum PU_RECORD_TYPE_E
    {
        PU_RECORD_TYPE_ALARM,
        PU_RECORD_TYPE_MANUAL,
        PU_RECORD_TYPE_TIMING,
        PU_RECORD_TYPE_MAX,
        PU_RECORD_METHOD_ADD,
        PU_RECORD_METHOD_ALL,
    }
    /// <summary>
    /// 硬盘类型
    /// </summary>
    public enum PU_DISK_TYPE_E
    {
        PU_DISK_TYPE_IDE = 1,
        PU_DISK_TYPE_SATA,
        PU_DISK_TYPE_FLASH,
        PU_DISK_TYPE_UNKNOWN
    }

    /// <summary>
    /// FEC丢包率
    /// </summary>
    public enum PU_FEC_PACKET_LOSS_RATIO_E
    {
        PU_FEC_PACKET_LOSS_RATIO_1 = 0,
        PU_FEC_PACKET_LOSS_RATIO_2 = 1,
        PU_FEC_PACKET_LOSS_RATIO_3 = 2,
        PU_FEC_PACKET_LOSS_RATIO_4 = 3,
        PU_FEC_PACKET_LOSS_RATIO_5 = 4,
        PU_FEC_PACKET_LOSS_RATIO_MAX
    }
    /// <summary>
    /// SEC丢包率
    /// </summary>
    public enum PU_SEC_PACKET_LOSS_RATIO_E
    {
        PU_SEC_PACKET_LOSS_RATIO_1 = 0,
        PU_SEC_PACKET_LOSS_RATIO_2 = 1,
        PU_SEC_PACKET_LOSS_RATIO_3 = 2,
        PU_SEC_PACKET_LOSS_RATIO_4 = 3,
        PU_SEC_PACKET_LOSS_RATIO_5 = 4,
        PU_SEC_PACKET_LOSS_RATIO_MAX
    }
    /// <summary>
    /// OSD颜色
    /// </summary>
    public enum PU_COLOR_TYPE_E
    {
        PU_COLOR_BLACK = 0,
        PU_COLOR_WHITE,
        PU_COLOR_MAX,
    }
    /// <summary>
    /// OSD透明度
    /// </summary>
    public enum PU_ALPHA_TYPE_E
    {
        PU_ALPHA_NONE = 0,
        PU_ALPHA_HALF,
        PU_ALPHA_ALL,
        PU_ALPHA_MAX
    }
    /// <summary>
    /// DSCP类型
    /// </summary>
    public enum PU_DSCP_TYPE_E
    {
        PU_DSCP_TYPE_MEDIA = 0,
        PU_DSCP_TYPE_CMD,
        PU_DSCP_TYPE_MAX
    }
    /// <summary>
    /// 智能区域检测类型
    /// </summary>
    public enum PU_IGT_AREA_ALARM_TYPE_E
    {
        PU_IGT_TYPE_INTRUSION = 0,
        PU_IGT_TYPE_HOVER,
        PU_IGT_TYPE_LEGACY,
        PU_IGT_TYPE_REMOVE,
        PU_IGT_TYPE_ENTER,
        PU_IGT_TYPE_EXIT,
        PU_IGT_TYPE_FASTMOVE,
        PU_IGT_TYPE_MAX
    }
    /// <summary>
    /// 智能场景使能
    /// </summary>
    public enum PU_IGT_FIELD_TYPE_E
    {
        PU_IGT_FIELD_LONGSHOT = 0,
        PU_IGT_FIELD_CLOSESHOT = 1,
        PU_IGT_FIELD_MAX
    }
    /// <summary>
    /// 前景目标尺寸设置
    /// </summary>
    public enum PU_IGT_MINTARGET_SIZE_E
    {
        PU_IGT_TARGETSIZE_SMALL = 0,
        PU_IGT_TARGETSIZE_MIDDLE = 1,
        PU_IGT_TARGETSIZE_BIG = 2,
        PU_IGT_TARGETSIZE_MAX
    }
    /// <summary>
    /// 去阴影模式
    /// </summary>
    public enum PU_IGT_SHADOW_MODE_E
    {
        PU_IGT_SHADOW_WEAK = 0,
        PU_IGT_SHADOW_COMMON = 1,
        PU_IGT_SHADOW_STRONG = 2,
        PU_IGT_SHADOW_MAX
    }
    /// <summary>
    /// 灵敏度设置
    /// </summary>
    public enum PU_IGT_DETECT_SENS_E
    {
        PU_IGT_SENS_LOW = 0,
        PU_IGT_SENS_MIDDLE = 1,
        PU_IGT_SENS_HIGH = 2,
        PU_IGT_SENS_LOWER = 3,
        PU_IGT_SENS_LOWEST = 4,
        PU_IGT_SENS_MAX
    }
    /// <summary>
    /// 智能目标识别模式
    /// </summary>
    public enum PU_IGT_TARGET_MODE_E
    {
        PU_IGT_TARGETMODE_CENTRE = 0,
        PU_IGT_TARGETMODE_BOTTOM = 1,
        PU_IGT_TARGETMODE_TOP = 2,
        PU_IGT_TARGETMODE_MAX
    }
    /// <summary>
    /// 智能操作类型
    /// </summary>
    public enum PU_IGT_OPT_TYPE_E
    {
        PU_IGT_OPT_TYPE_ADD = 0,
        PU_IGT_OPT_TYPE_MOD = 1,
        PU_IGT_OPT_TYPE_DEL = 2,
        PU_IGT_OPT_TYPE_MOV = 3,
        PU_IGT_OPT_TYPE_MAX
    }
    /// <summary>
    /// 典型场景模式
    /// </summary>
    public enum PU_TYPICAL_SCENE_MODE_E
    {
        PU_TYPICAL_SCENE_DEFAULT = 0,
        PU_TYPICAL_SCENE_OUT_DOOR,
        PU_TYPICAL_SCENE_IN_DOOR,
        PU_TYPICAL_SCENE_LOW_LIGHT,
        PU_TYPICAL_SCENE_MOVE,
        PU_TYPICAL_SCENE_BACKLIGHT,
        PU_TYPICAL_SCENE_USER_1,
        PU_TYPICAL_SCENE_USER_2,
        PU_TYPICAL_SCENE_USER_3,
        PU_TYPICAL_SCENE_USER_4,
        PU_TYPICAL_SCENE_USER_5,
        PU_TYPICAL_SCENE_USER_6,
        PU_TYPICAL_SCENE_USER_7,
        PU_TYPICAL_SCENE_USER_8,
        PU_TYPICAL_SCENE_FOGGY,
        PU_TYPICAL_SCENE_FACE,
        PU_TYPICAL_SCENE_NONE = 128,
        PU_TYPICAL_SCENE_MAX
    }
    /// <summary>
    /// 强光抑制模式
    /// </summary>
    public enum PU_BLAZE_RESTRAIN_MODE_E
    {
        PU_BLAZE_RESTRAIN_OPEN = 0,
        PU_BLAZE_RESTRAIN_CLOSE,
        PU_BLAZE_RESTRAIN_MAX
    }
    /// <summary>
    /// 去雾等级
    /// </summary>
    public enum PU_DEFOG_TYPR_E
    {
        PU_DEFOG_TYPE_CLOSE = 0,
        PU_DEFOG_TYPE_LOW,
        PU_DEFOG_TYPE_MIDDLING,
        PU_DEFOG_TYPE_HIGH,
        PU_DEFOG_TYPE_MAX
    }
    /// <summary>
    /// 操作类型
    /// </summary>
    public enum PU_OPT_TYPE_E
    {
        PU_OPT_TYPE_ADD = 0,
        PU_OPT_TYPE_DEL = 1,
        PU_OPT_TYPE_MOD = 2,
        PU_OPT_TYPE_MAX
    }
    /// <summary>
    /// SNMP版本
    /// </summary>
    public enum PU_SNMP_VERSION_TYPE_E
    {
        PU_SNMP_VERSION_V1 = 0,
        PU_SNMP_VERSION_V2C,
        PU_SNMP_VERSION_V3,
        PU_SNMP_VERSION_MAX
    }
    /// <summary>
    /// SNMP v1/v2c社团属性
    /// </summary>
    public enum PU_SNMP_COMMUNITY_ATTR_E
    {
        PU_SNMP_COMMUNITY_READONLY = 0,
        PU_SNMP_COMMUNITY_READWRITE,
        PU_SNMP_COMMUNITY_MAX
    }
    /// <summary>
    /// SNMP v3用户安全级别
    /// </summary>
    public enum PU_SNMPV3_SECURITY_LEVEL_E
    {
        PU_SNMPV3_SECURITY_NOAUTH = 0,
        PU_SNMPV3_SECURITY_AUTH,
        PU_SNMPV3_SECURITY_PRIV,
        PU_SNMPV3_SECURITY_MAX
    }
    /// <summary>
    /// SNMP v3密码认证协议
    /// </summary>
    public enum PU_SNMPV3_AUTH_PROTOCOL_E
    {
        PU_SNMPV3_AUTH_MD5 = 0,
        PU_SNMPV3_AUTH_SHA,
        PU_SNMPV3_AUTH_NONE,
        PU_SNMPV3_AUTH_MAX
    }
    /// <summary>
    /// SNMP v3私有密钥协议
    /// </summary>
    public enum PU_SNMPV3_PRIV_PROTOCOL_E
    {
        PU_SNMPV3_PRIV_DES = 0,
        PU_SNMPV3_PRIV_AES,
        PU_SNMPV3_PRIV_NONE,
        PU_SNMPV3_PRIV_MAX
    }
    /// <summary>
    /// EAPOL版本号
    /// </summary>
    public enum PU_DOT1X_EAPOL_VERSION_E
    {
        PU_DOT1X_EAPOL_VERSION_1 = 1,
        PU_DOT1X_EAPOL_VERSION_2,
        PU_DOT1X_EAPOL_VERSION_MAX
    }
    /// <summary>
    /// 方向
    /// </summary>
    public enum PU_PTZ_DIRECTION_E
    {
        PU_PTZ_DIRECTION_UP,
        PU_PTZ_DIRECTION_DOWN,
        PU_PTZ_DIRECTION_LEFT,
        PU_PTZ_DIRECTION_RIGHT,
        PU_PTZ_DIRECTION_MAX
    }
    /// <summary>
    /// 守望类型
    /// </summary>
    public enum PU_GUARD_POINT_TYPE_E
    {
        PU_GUARD_POINT_PRESET,
        PU_GUARD_POINT_CRUISE,
        PU_GUARD_POINT_USER_DEFINED,
        PU_GUARD_POINT_HORIZONTAL,
        PU_GUARD_POINT_FRAME,
        PU_GUARD_POINT_RANDOM,
        PU_GUARD_POINT_PANORAMA,
        PU_GUARD_POINT_VERTICAL,
        PU_GUARD_POINT_MAX
    }
    /// <summary>
    /// 辅助设备输出模式
    /// </summary>
    public enum PU_PTZ_AUX_MODE_E
    {
        PU_AUX_MODE_PROTOCOL = 0,
        PU_AUX_MODE_ALARMOUT = 1,
        PU_AUX_MODE_TORRENTIAL_RAIN = 2,
        PU_AUX_MODE_MODERATE_RAIN = 3,
        PU_AUX_MODE_MAX
    }
    /// <summary>
    /// WEB协议类型
    /// </summary>
    public enum PU_WEB_HTTP_MODE_E
    {
        PU_WEB_HTTPS_HTTP = 0,
        PU_WEB_HTTPS_ONLY = 1,
        PU_WEB_HTTP_MAX,
    }
    /// <summary>
    /// 用户类型
    /// </summary>
    public enum PU_USER_TYPE_E
    {
        PU_USER_TYPE_SYSTEM_ADMIN = 0,
        PU_USER_TYPE_ADVANCED_OPERATOR,
        PU_USER_TYPE_COMMON_OPERATOR,
        PU_USER_TYPE_MAX
    }
    /// <summary>
    /// AF对焦模式
    /// </summary>
    public enum PU_FOCUS_MODE_E
    {
        PU_FOCUS_MODE_AUTO = 0,
        PU_FOCUS_MODE_MANUAL = 1,
        PU_FOCUS_MODE_MAX
    }
    /// <summary>
    /// 码流套餐模式
    /// </summary>
    public enum PU_STREAM_PROFILE_MODE_E
    {
        PU_STREAM_PROFILE_DEFAULT = 0,
        PU_STREAM_PROFILE_HIGH_QUALITY,
        PU_STREAM_PROFILE_BALANCED,
        PU_STREAM_PROFILE_LOW_BANDWIDTH,
        PU_STREAM_PROFILE_MOBILE_DEVICE,
        PU_STREAM_PROFILE_USER_1,
        PU_STREAM_PROFILE_USER_2,
        PU_STREAM_PROFILE_USER_3,
        PU_STREAM_PROFILE_USER_4,
        PU_STREAM_PROFILE_MAX
    }
    /// <summary>
    /// 降噪模式
    /// </summary>
    public enum PU_NOISE_REDUCTION_MODE_E
    {
        PU_NOISE_REDUCTION_CLOSE = 0,
        PU_NOISE_REDUCTION_NORMAL,
        PU_NOISE_REDUCTION_EXPERT,
        PU_NOISE_REDUCTION_MAX
    }
    /// <summary>
    /// 字符编码
    /// </summary>
    public enum PU_CHAR_ENCODE_TYPE_E
    {
        PU_CHAR_ENCODE_ANSI = 0,
        PU_CHAR_ENCODE_UTF_8 = 1,
        PU_CHAR_ENCODE_MAX,
    }
    /// <summary>
    /// 视频采集帧制式
    /// </summary>
    public enum PU_FRAMERATE_FORMAT_E
    {
        PU_FRAME_RATE_25F = 1,
        PU_FRAME_RATE_30F,
        PU_FRAME_RATE_50F,
        PU_FRAME_RATE_60F,
        PU_FRAME_RATE_MAX,
    }
    /// <summary>
    /// 流套餐操作
    /// </summary>
    public enum PU_STREAM_MANIPULATE_TYPE_E
    {
        PU_STREAM_MANIPULATE_ADD = 0,
        PU_STREAM_MANIPULATE_DELETE,
        PU_STREAM_MANIPULATE_MODIFY,
        PU_STREAM_MANIPULATE_MAX
    }
    /// <summary>
    /// IP地址过滤协议
    /// </summary>
    public enum PU_IP_PROTOCOL_TYPE_E
    {
        PU_IP_PROTOCOL_TYPE_UDP = 0,
        PU_IP_PROTOCOL_TYPE_TCP,
        PU_IP_PROTOCOL_TYPE_ICMP,
        PU_IP_PROTOCOL_TYPE_ALL,
        PU_IP_PROTOCOL_TYPE_MAX
    }
    /// <summary>
    /// IP过滤策略
    /// </summary>
    public enum PU_IP_FILTER_STRATEGY_E
    {
        PU_IP_FILTER_STRATEGY_ALLOW = 0,
        PU_IP_FILTER_STRATEGY_DENY,
        PU_IP_FILTER_STRATEGY_MAX
    }
    /// <summary>
    /// 802.1x EAP-TLS证书上传类型
    /// </summary>
    public enum PU_DOT1X_TLS_CERT_UPLOAD_TYPE_E
    {
        PU_DOT1X_TLS_CA_CERT_UPLOAD_TYPE = 0,
        PU_DOT1X_TLS_CLIENT_CERT_UPLOAD_TYPE,
        PU_DOT1X_TLS_CERT_UPLOAD_TYPE_MAX
    }
    /// <summary>
    /// 最小聚焦距离
    /// </summary>
    public enum PU_MIN_FOCUS_E
    {
        PU_MIN_FOCUS_10 = 10,  //1cm   
        PU_MIN_FOCUS_100 = 100,
        PU_MIN_FOCUS_300 = 300,
        PU_MIN_FOCUS_500 = 500,
        PU_MIN_FOCUS_1000 = 1000,  //1m
        PU_MIN_FOCUS_1500 = 1500,
        PU_MIN_FOCUS_2000 = 2000,
        PU_MIN_FOCUS_3000 = 3000,
        PU_MIN_FOCUS_5000 = 5000,
        PU_MIN_FOCUS_10000 = 10000,  //10m
        PU_MIN_FOCUS_20000 = 20000,
        PU_MIN_FOCUS_50000 = 50000,
        PU_MIN_FOCUS_100000 = 100000,  //100m
        PU_MIN_FOCUS_MAX
    }
    /// <summary>
    /// Iris类型
    /// </summary>
    public enum PU_IRIS_TYPE_E
    {
        PU_IRIS_TYPE_DC = 0,
        PU_IRIS_TYPE_P_IRIS,
        PU_IRIS_TYPE_MANUAL,
        PU_IRIS_TYPE_BUTT,
    }
    /// <summary>
    /// 快门参数
    /// </summary>
    public enum PU_CAM_SHUTTER_MODE_E
    {
        PU_SHUTTER_MODE_1 = 0,
        PU_SHUTTER_MODE_2,
        PU_SHUTTER_MODE_4,
        PU_SHUTTER_MODE_8,
        PU_SHUTTER_MODE_12,
        PU_SHUTTER_MODE_15,
        PU_SHUTTER_MODE_25,
        PU_SHUTTER_MODE_30,
        PU_SHUTTER_MODE_50,
        PU_SHUTTER_MODE_60,
        PU_SHUTTER_MODE_90,
        PU_SHUTTER_MODE_100,
        PU_SHUTTER_MODE_120,
        PU_SHUTTER_MODE_125,
        PU_SHUTTER_MODE_180,
        PU_SHUTTER_MODE_250,
        PU_SHUTTER_MODE_350,
        PU_SHUTTER_MODE_500,
        PU_SHUTTER_MODE_725,
        PU_SHUTTER_MODE_1000,
        PU_SHUTTER_MODE_1500,
        PU_SHUTTER_MODE_2000,
        PU_SHUTTER_MODE_3000,
        PU_SHUTTER_MODE_4000,
        PU_SHUTTER_MODE_6000,
        PU_SHUTTER_MODE_10000,
        PU_SHUTTER_MODE_30000,
        PU_SHUTTER_MODE_100000,
        PU_SHUTTER_MODE_3,
        PU_SHUTTER_MODE_MAX
    }
    /// <summary>
    /// 抓拍图片格式
    /// </summary>
    public enum PU_SNAPSHOT_FORMAT_E
    {
        PU_SNAPSHOT_FORMAT_BMP = 0,
        PU_SNAPSHOT_FORMAT_JPEG
    }
    /// <summary>
    /// 上传类型
    /// </summary>
    public enum PU_FTP_UPLOAD_PROTOCOL_TYPE_E
    {
        PU_FTP_UPLOAD_PROTOCOL_TYPE_FTP = 0,
        PU_FTP_UPLOAD_PROTOCOL_TYPE_SFTP,
        FTP_UPLOAD_PROTOCOL_TYPE_MAX
    }
    /// <summary>
    /// 目录结构
    /// </summary>
    public enum PU_FTP_UPLOAD_DIR_TYPE_E
    {
        PU_FTP_UPLOAD_DIR_TYPE_ROOT_DIR = 0,   //上传到根目录
        PU_FTP_UPLOAD_DIR_TYPE_FIRST_DIR,      //上传到一级目录
        PU_FTP_UPLOAD_DIR_TYPE_SECOND_DIR,     //上传到二级目录
        PU_FTP_UPLOAD_DIR_TYPE_THIRD_DIR,      //上传到三级目录
        PU_FTP_UPLOAD_DIR_TYPE_FOURTH_DIR,     //上传到四级目录
        FTP_UPLOAD_DIR_TYPE_MAX
    }
    /// <summary>
    /// 一级目录类型
    /// </summary>
    public enum PU_FTP_UPLOAD_FIRST_DIR_TYPE_E
    {
        PU_FTP_UPLOAD_FIRST_DIR_TYPE_IP = 0,   //一级目录为设备IP 
        PU_FTP_UPLOAD_FIRST_DIR_TYPE_SELF,     //一级目录为自定义
        FTP_UPLOAD_FIRST_DIR_TYPE_MAX
    }
    /// <summary>
    /// 二级目录类型
    /// </summary>
    public enum PU_FTP_UPLOAD_SECOND_DIR_TYPE_E
    {
        PU_FTP_UPLOAD_SECOND_DIR_TYPE_CHANNEL = 0, //二级目录为通道号
        PU_FTP_UPLOAD_SECOND_DIR_TYPE_SELF,        //二级目录为自定义
        PU_FTP_UPLOAD_SECOND_DIR_TYPE_MAX
    }
    /// <summary>
    /// 上传文件命名规则
    /// </summary>
    public enum PU_FTP_UPLOAD_FILE_NAMING_RULE_E
    {
        PU_FTP_UPLOAD_FILE_NAMING_RULE_DATE = 0,   //以时间命名
        PU_FTP_UPLOAD_FILE_NAMING_RULE_MAX
    }
    /// <summary>
    /// 前端录像计划操作方法
    /// </summary>
    public enum PU_LOCAL_RECORD_PLAN_OPR_E
    {
        LOCAL_RECORD_PLAN_ADD_OPR = 0,
        LOCAL_RECORD_PLAN_DEL_OPR,
        LOCAL_RECORD_PLAN_MODIFY_OPR,
        LOCAL_RECORD_PLAN_RESET_OPR,
        LOCAL_RECORD_PLAN_OPR_MAX
    }
    /// <summary>
    /// 星期枚举值
    /// </summary>
    public enum PU_WEEK_DATE_E
    {
        WEEK_EVERYDAY = 0,
        WEEK_MONDAY = 1,
        WEEK_TUESDAY = 2,
        WEEK_WEDNESDAY = 3,
        WEEK_THURSDAY = 4,
        WEEK_FRIDAY = 5,
        WEEK_SATURDAY = 6,
        WEEK_SUNDAY = 7
    }
    /// <summary>
    /// 前端SDC模块
    /// </summary>
    public enum IPC_MODULE_E
    {
        IPC_WEB_MODULE = 0,
        IPC_SDK_MODULE = 1,
    }
    /// <summary>
    /// ISP通用开关
    /// </summary>
    public enum PU_COMMONMODE_SWITCH_E
    {
        MODE_OPEN = 0, //打开模式
        MODE_CLOSE, //关闭模式
        MODE_AUTO, //自动模式
        MODE_MANUAL, //手动模式
        MODE_MAX
    }
    /// <summary>
    /// 变倍变焦动作控制
    /// </summary>
    public enum PU_CAMCTRL_E
    {
        PU_CAM_CONTROL_UP = 0,
        PU_CAM_CONTROL_DOWN,
        PU_CAM_CONTROL_STOP
    }
    /// <summary>
    /// 缓存补录类型
    /// </summary>
    public enum PU_CACHERECORD_E
    {
        PU_RECORD_CLOSE = 0,
        PU_RECORD_OFFLINE,
        PU_RECORD_MAX
    }
    /// <summary>
    /// 流量整形系数
    /// </summary>
    public enum PU_TS_COEFFICIENT_E
    {
        PU_TS_COEFFICIENT_11 = 11,
        PU_TS_COEFFICIENT_12 = 12,
        PU_TS_COEFFICIENT_13 = 13,
        PU_TS_COEFFICIENT_14 = 14,
        PU_TS_COEFFICIENT_15 = 15,
        PU_TS_COEFFICIENT_16 = 16,
        PU_TS_COEFFICIENT_17 = 17,
        PU_TS_COEFFICIENT_18 = 18,
        PU_TS_COEFFICIENT_19 = 19,
        PU_TS_COEFFICIENT_20 = 20,
        PU_TS_COEFFICIENT_21 = 21,
        PU_TS_COEFFICIENT_22 = 22,
        PU_TS_COEFFICIENT_23 = 23,
        PU_TS_COEFFICIENT_24 = 24,
        PU_TS_COEFFICIENT_25 = 25,
        PU_TS_COEFFICIENT_26 = 26,
        PU_TS_COEFFICIENT_27 = 27,
        PU_TS_COEFFICIENT_28 = 28,
        PU_TS_COEFFICIENT_29 = 29,
        PU_TS_COEFFICIENT_30 = 30,
        PU_TS_COEFFICIENT_31 = 31,
        PU_TS_COEFFICIENT_32 = 32,
        PU_TS_COEFFICIENT_33 = 33,
        PU_TS_COEFFICIENT_34 = 34,
        PU_TS_COEFFICIENT_35 = 35,
        PU_TS_COEFFICIENT_36 = 36,
        PU_TS_COEFFICIENT_37 = 37,
        PU_TS_COEFFICIENT_38 = 38,
        PU_TS_COEFFICIENT_39 = 39,
        PU_TS_COEFFICIENT_40 = 40,
    }
    /// <summary>
    /// 夏令时实施方式
    /// </summary>
    public enum PU_DST_TYPE_E
    {
        DST_WEEK_WAY = 0,
        DST_DATE_WAY = 1,
        DST_TYPE_MAX = 2,
    }
    /// <summary>
    /// 夏令时偏移量
    /// </summary>
    public enum PU_DST_OFFSET_E
    {
        OFFSET_30_MIN = 30,
        OFFSET_60_MIN = 60,
        OFFSET_90_MIN = 90,
        OFFSET_120_MIN = 120,
    }
    /// <summary>
    /// ONVIF鉴权类型
    /// </summary>
    public enum PU_ONVIF_AUTH_TYPE_E
    {
        AUTH_TYPE_DIGGEST = 0,
        AUTH_TYPE_DIGGEST_AND_WSSE = 1,
        AUTH_TYPE_NONE = 2,
        AUTH_TYPE_WSSE = 3,
        AUTH_TYPE_DIGEST_SHA256,
        AUTH_TYPE_DIGEST_MD5_AND_SHA256,
        AUTH_TYPE_MAX
    }
    /// <summary>
    /// 加密类型
    /// </summary>
    public enum PU_SMTP_SECURITY_TYPE_E
    {
        PU_NO_SECURITY = 0,
        PU_USE_TLS,
        PU_USE_SSL,
        PU_DO_NOT_SET
    }
    /// <summary>
    /// 车牌颜色
    /// </summary>
    public enum PU_PLATE_COLOR_E
    {
        PU_LPR_LC_UNKNOWN = 0,
        PU_LPR_LC_BLUE = 1,
        PU_LPR_LC_YELLOW = 2,
        PU_LPR_LC_WHITE = 3,
        PU_LPR_LC_BLACK = 4,
        PU_LPR_LC_GREEN = 5,
        PU_LPR_LC_GRADIENT_GREEN = 6,
        PU_LPR_LC_YELLOW_GREEN = 7,
        PU_LPR_LC_RED_WHITE = 8,
        PU_LPR_LC_WHITE_RED = 9,
        PU_LPR_LC_BLUE_WHITE = 10,
        PU_LPR_LC_WHITE_BLUE = 11,
        PU_LPR_LC_WHITE_YELLOW = 12,
        PU_LPR_LC_WHITE_GREEN = 13,
        PU_LPR_LC_WHITE_SILVER = 14,
        PU_LPR_LC_SILVER_BLACK = 15,
    }
    /// <summary>
    /// 车牌类型
    /// </summary>
    public enum PU_PLATE_TYPE_E
    {
        PU_LPR_PLT_UNKNOWN = 0,  //未知类型    
        PU_LPR_PLT_NORMBLUE = 1,  //普通蓝牌    
        PU_LPR_PLT_NORMBLACK = 2,  //普通黑牌    
        PU_LPR_PLT_NORMYELLOW = 3,  //普通单层黄牌    
        PU_LPR_PLT_DBLYELLOW = 4,  //双层黄牌    
        PU_LPR_PLT_POLICE = 5,  //白色警牌    
        PU_LPR_PLT_WJ = 6,  //白色武警    
        PU_LPR_PLT_DBLWJ = 7,  //双层白色武警    
        PU_LPR_PLT_ARMY = 8,  //单层军牌    
        PU_LPR_PLT_DBLARMY = 9,  //双层军牌    
        PU_LPR_PLT_EMBASSY = 10, //领使馆牌    
        PU_LPR_PLT_HK = 11, //港牌    
        PU_LPR_PLT_MACAU = 13, //澳门牌    
        PU_LPR_PLT_AGRICULTURE = 14, //农用车牌 拖拉机    
        PU_LPR_PLT_CHANGNEI = 15, //厂内牌    
        PU_LPR_PLT_INDIVI = 16, //个性化车牌    
        PU_LPR_PLT_NEWNENRGY = 17, //新能源牌       
        PU_LPR_PLT_OTHER = 18, //其他类型    
        PU_VLPR_LPT_INA_PRIVATE = 100,  //印尼私家车    
        PU_VLPR_LPT_INA_PUBLIC = 101,  //印尼公共交通    
        PU_VLPR_LPT_INA_EMBASSY = 102,  //印尼使馆牌    
        PU_VLPR_LPT_KSA_PRIVATE = 110,  //沙特车牌    
        PU_VLPR_LPT_SAU_OTHER = 112,    //沙特其他车    
        PU_VLPR_LPT_HK_PRIVATE = 120,   //香港车牌    
        PU_VLPR_LPR_BRA_PRIVATE = 130,     //巴西私家车
        PU_VLPR_LPR_BRA_COMMERCIAL = 131,  //巴西商务车
        PU_VLPR_LPR_BRA_OFFICIAL = 132,    //巴西官方车
        PU_VLPR_LPR_BRA_DIPLOMATIC = 133,  //巴西使馆车
        PU_VLPR_LPR_BRA_MOTO = 134,        //巴西摩托车
        PU_VLPR_LPR_BRA_OTHER = 135,       //巴西其他车
        PU_VLPR_LPR_MEX_PRIVATE = 140,     //墨西哥私家车
        PU_VLPR_LPR_MEX_BUS = 141,         //墨西哥公交车
        PU_VLPR_LPR_MEX_TAXI = 142,        //墨西哥出租车
        PU_VLPR_LPR_MEX_TRUCK = 143,       //墨西哥卡车
        PU_VLPR_LPR_MEX_MOTO = 144,        //墨西哥摩托车
        PU_VLPR_LPR_MEX_OTHER = 145,       //墨西哥其他车
        PU_VLPR_LPR_ARG_PRIVATE = 150,     //阿根廷私家车
        PU_VLPR_LPR_ARG_OFFICIAL = 151,    //阿根廷官方车
        PU_VLPR_LPR_ARG_MOTO = 152,        //阿根廷摩托车
        PU_VLPR_LPR_ARG_OTHER = 153,       //阿根廷其他车
        PU_VLPR_LPR_ZAF_PRIVATE = 160,     //南非机动车
        PU_VLPR_LPR_ZAF_OFFICIAL = 161,    //南非政府车
        PU_VLPR_LPR_ZAF_DIPLOMATIC = 162,  //南非使馆车
        PU_VLPR_LPR_ZAF_POLICE = 163,      //南非警车
        PU_VLPR_LPR_ZAF_MILITARY = 164,    //南非军车
        PU_VLPR_LPR_ZAF_MOTO = 165,        //南非摩托车
        PU_VLPR_LPR_ZAF_OTHER = 166,       //南非其他车
        PU_VLPR_LPR_GHA_PRIVATE = 170,     //加纳私家车
        PU_VLPR_LPR_GHA_OFFICIAL = 171,    //加纳政府车
        PU_VLPR_LPR_GHA_DIPLOMATIC = 172,  //加纳外交车
        PU_VLPR_LPR_GHA_COMMERCIAL = 173,  //加纳商用车
        PU_VLPR_LPR_GHA_MOTO = 174,        //加纳摩托车
        PU_VLPR_LPR_GHA_OTHER = 175,       //加纳其他车
    }
    /// <summary>
    /// 车身颜色
    /// </summary>
    public enum PU_VEHICLE_COLOR_E
    {
        PU_LPR_VC_NOT,
        PU_LPR_VC_WHITE,
        PU_LPR_VC_GRAY,
        PU_LPR_VC_YELLOW,
        PU_LPR_VC_PINK,
        PU_LPR_VC_RED,
        PU_LPR_VC_GREEN,
        PU_LPR_VC_BLUE,
        PU_LPR_VC_BROWN,
        PU_LPR_VC_BLACK,
        PU_LPR_VC_PURPLE,
        PU_LPR_VC_ORANGE,
        PU_LPR_VC_CYAN,
        PU_LPR_VC_GOLDEN,
        PU_LPR_VC_SILVER,
    }
    /// <summary>
    /// 车牌移动方向
    /// </summary>
    public enum PU_PLATE_DIR_E
    {
        PU_LPR_UNKNOWN = 0,
        PU_LPR_LEFT = 1,
        PU_LPR_RIGHT = 2,
        PU_LPR_UP = 3,
        PU_LPR_DOWN = 4
    }
    /// <summary>
    /// 车辆方向定义
    /// </summary>
    public enum PU_VEHICLE_DIR_E
    {
        PU_VLPR_VD_HEAD = 0,
        PU_VLPR_VD_TAIL = 1,
        PU_VLPR_VD_HEAD_AND_TAIL = 2
    }
    /// <summary>
    /// 获取车辆模式
    /// </summary>
    public enum PU_VLPR_CATCH_MODE_E
    {
        PU_VLPR_MODE_MOTORWAY = 0,
        PU_VLPR_MODE_COEXISTED = 1
    }
    /// <summary>
    /// 背光补偿模式
    /// </summary>
    public enum BACKLIGHT_MODE_E
    {
        VIDEO_MODE_AVERAGE = 0,
        VIDEO_MODE_CENTER,
        VIDEO_MODE_UP,
        VIDEO_MODE_DOWN,
        VIDEO_MODE_LEFT,
        VIDEO_MODE_RIGHT,
        VIDEO_MODE_USER
    }
    /// <summary>
    /// 云镜OSD模式
    /// </summary>
    public enum PTZ_OSD_MODE_E
    {
        PTZ_OSD_NONE,
        PTZ_OSD_PTZ_INFO,
        PTZ_OSD_ORIENTATION,
        PTZ_OSD_POSITION,
        PTZ_OSD_ZOOM,
    }
    /// <summary>
    /// 补光灯IO模式
    /// </summary>
    public enum PU_SUPPLEMENT_LIGHT_LAMP_IO_MODE_E
    {
        PU_IO_CONTINUE_MODE = 0,
        PU_IO_MODE_MAX
    }
    /// <summary>
    /// 补光灯控制模式
    /// </summary>
    public enum PU_SUPPLEMENT_LIGHT_LAMP_CTRL_MODE_E
    {
        PU_CONTROL_DISABLE_MODE = 0,
        PU_CONTROL_AUTO_MODE,
        PU_CONTROL_TIME_MODE,
        PU_CONTROL_MODE_MAX
    }
    /// <summary>
    /// 邮件类型
    /// </summary>
    public enum PU_SMTP_MAIL_TYPE
    {
        FOR_TEST,
        FOR_EVENT
    }
    /// <summary>
    /// 一张合成方式
    /// </summary>
    public enum PU_ONE_PIC_SYNTHESIS_TYPE_E
    {
        PU_ONE_PIC_SYNTHESIS_TYPE1 = 0,
        PU_ONE_PIC_SYNTHESIS_TYPE2,
        PU_ONE_PIC_SYNTHESIS_TYPE3,
        PU_ONE_PIC_SYNTHESIS_TYPE4,
        PU_ONE_PIC_NO_SYNTHESIS,
        PU_ONE_PIC_SYNTHESIS_TYPE_MAX
    }
    /// <summary>
    /// 两张合成方式
    /// </summary>
    public enum PU_TWO_PIC_SYNTHESIS_TYPE_E
    {
        PU_TWO_PIC_SYNTHESIS_TYPE1 = 0,
        PU_TWO_PIC_SYNTHESIS_TYPE2,
        PU_TWO_PIC_SYNTHESIS_TYPE3,
        PU_TWO_PIC_SYNTHESIS_TYPE4,
        PU_TWO_PIC_SYNTHESIS_TYPE5,
        PU_TWO_PIC_SYNTHESIS_TYPE6,
        PU_TWO_PIC_SYNTHESIS_TYPE7,
        PU_TWO_PIC_SYNTHESIS_TYPE8,
        PU_TWO_PIC_SYNTHESIS_TYPE9,
        PU_TWO_PIC_SYNTHESIS_TYPE10,
        PU_TWO_PIC_NO_SYNTHESIS,
        PU_TWO_PIC_SYNTHESIS_TYPE_MAX
    }
    /// <summary>
    /// 三张合成方式
    /// </summary>
    public enum PU_THREE_PIC_SYNTHESIS_TYPE_E
    {
        PU_THREE_PIC_SYNTHESIS_TYPE1 = 0,
        PU_THREE_PIC_SYNTHESIS_TYPE2,
        PU_THREE_PIC_SYNTHESIS_TYPE3,
        PU_THREE_PIC_SYNTHESIS_TYPE4,
        PU_THREE_PIC_SYNTHESIS_TYPE5,
        PU_THREE_PIC_SYNTHESIS_TYPE6,
        PU_THREE_PIC_SYNTHESIS_TYPE7,
        PU_THREE_PIC_SYNTHESIS_TYPE8,
        PU_THREE_PIC_NO_SYNTHESIS,
        PU_THREE_PIC_SYNTHESIS_TYPE_MAX
    }
    /// <summary>
    /// 叠加文字大小
    /// </summary>
    public enum PU_FONT_SIZE_E
    {
        PU_OSD_FONT_SIZE_SMALL = 0,
        PU_OSD_FONT_SIZE_MEDIUM,
        PU_OSD_FONT_SIZE_LARGE,
        PU_OSD_FONT_SIZE_MAX
    }
    /// <summary>
    /// 叠加文字大小扩充
    /// </summary>
    public enum PU_FONT_SIZE_EXT_E
    {
        PU_OSD_FONT_SIZE_16,
        PU_OSD_FONT_SIZE_24,
        PU_OSD_FONT_SIZE_32,
        PU_OSD_FONT_SIZE_48,
        PU_OSD_FONT_SIZE_64,
        PU_OSD_FONT_SIZE_96,
        PU_OSD_FONT_SIZE_128,
        PU_OSD_FONT_SIZE_EXT_MAX,
    }
    /// <summary>
    /// 叠加信息类型
    /// </summary>
    public enum PU_PIC_OSD_TYPE_E
    {
        PU_TIME_OSD = 0,
        PU_PLATE_ID_OSD,
        PU_VEHICLE_TYPE_OSD,
        PU_LANE_ID_OSD,
        PU_PLATE_COLOR_OSD,
        PU_VEHICLE_COLOR_OSD,
        PU_ROAD_ID_OSD,
        PU_DEV_ID_OSD,
        PU_DIR_ID_OSD,
        PU_DIR_OSD,
        PU_CUSTOM_OSD,
        PU_SECURITY_CODE_OSD,
        PU_PRE_BRAND_TYPE_OSD,
        PU_SUB_BRAND_TYPE_OSD,
        PU_YEAR_BRAND_TYPE_OSD,
        PU_LOCATE_DESC_OSD,
        PU_MONITOR_INFO_OSD,
        PU_BRAND_INFO_OSD,
        PU_VEHICLE_SPEED_OSD,
        PU_LANE_DESC_OSD,
        PU_SNAP_SERIAL_NUM_OSD,
        PU_ILLEGAL_NUM_OSD,
        PU_ILLEGAL_DESC_OSD,
        PU_SPEED_LIMIT_OSD,
        PU_ILLEGAL_SPEED_OSD,
        PU_LANE_DIR_DESC_OSD,
        PU_VEHICLE_LEN_DESC_OSD,
        PU_REDLIGHT_START_OSD,
        PU_REDLIGHT_END_OSD,
        PU_REDLIGHT_PERIOD_OSD,
        PU_SNAPTRIG_OSD,
        PU_VEHICLE_MFR_TYPE_OSD,
        PU_RADAR_CHECK_DIR_OSD,
        PU_VEHICLE_DIR_OSD,
        PU_VEHICLE_TYPE_EXT_OSD,
        PU_PIC_OSD_TYPE_MAX
    }
    /// <summary>
    /// 文字叠加位置
    /// </summary>
    public enum PU_PIC_OSD_LOCATION_E
    {
        PU_PIC_IN_TOP = 0,
        PU_PIC_IN_BOTTOM,
        PU_PIC_OUT_TOP,
        PU_PIC_OUT_BOTTOM,
        PU_PIC_OSD_LOCATION_MAX
    }
    /// <summary>
    /// 叠加图片类型
    /// </summary>
    public enum PU_OVERLAY_PIC_TYPE_E
    {
        PU_ORG_PIC = 0,   // 原图
        PU_SYNTHESIS_PIC, // 合成图
        PU_OVERLAY_PIC_TYPE_MAX
    }
    /// <summary>
    /// 质量诊断告警类型
    /// </summary>
    public enum PU_ALARM_VIDEODIAGNOSIS_TYPE_E
    {
        ALARM_SHAKE = 0,            // 抖动诊断
        ALARM_FROZEN,           // 画面冻结诊断
        ALARM_NOISE,           // 雪花噪声诊断
        ALARM_STRIPENOISE,            // 条纹噪声诊断
        ALARM_BRIGHT,             // 亮度诊断
        ALARM_COLORCAST,         // 偏色诊断
        ALARM_VIDEODIAGNOSIS_TYPE_MAX
    }
    /// <summary>
    /// ISP视频模式类型
    /// </summary>
    public enum PU_ISP_IRCUT_MODULE_E
    {
        PU_IRCUT_MODE_DUMMY = 0,         //彩色模式    
        PU_IRCUT_MODE_NIGHT,           //黑白模式    
        PU_IRCUT_MODE_DEFOG,         //光学透雾(暂不支持)    
        PU_IRCUT_MODE_MAX
    }
    /// <summary>
    /// IP过滤匹配方式
    /// </summary>
    public enum PU_IPFILTER_MATCH_TYPE_E
    {
        MATCH_IP = 0,
        MATCH_MAC = 1,
        MATCH_IP_AND_MAC = 2,
    }

    public enum PU_ALARM_LINK_PTZ_PRIORITY_E
    {
        PU_GUARD_FIRST = 0,//守望优先-->当守望时间到时，直接触发，无论当前是否在告警
        PU_ALARM_FIRST,     //告警联动优先 --> 当告警发生到告警结束，守望不生效   
        PU_LINK_MAX,
    }
    /// <summary>
    /// 绊线方向类型
    /// </summary>
    public enum PU_TRIPWIRE_DIR_E
    {
        PU_TRIPWIRE_CLOCKWISE = 0,
        PU_TRIPWIRE_ANTICLOCKWISE,
        PU_TRIPWIRE_MAX
    }
    /// <summary>
    /// 人头计数报表类型
    /// </summary>
    public enum PU_TABLE_TYPE_E
    {
        PU_TABLE_DAY,
        PU_TABLE_WEEK,
        PU_TABLE_MONTH,
        PU_TABLE_YEAR
    }
    /// <summary>
    /// 人脸人体检测模式
    /// </summary>
    public enum PU_FACE_DETECTION_DL_MODE_E
    {
        FACE_MODE = 0,  //人脸检测
        BODY_MODE,      //人体检测
        FACE_BODY_MODE, //人脸、人体检测
    }
    /// <summary>
    /// 分隔符类型
    /// </summary>
    public enum PU_SEPARATOR_TYPE_E
    {
        PU_SEPARATOR_TYPE_DOT = 0,   //'.'    
        PU_SEPARATOR_TYPE_PLUS,      //'+'    
        PU_SEPARATOR_TYPE_MINUS,     //'-'    
        PU_SEPARATOR_TYPE_UNDERLINE, //'_'    
        PU_SEPARATOR_TYPE_EQUAL,     //'='    
        PU_SEPARATOR_TYPE_MAX,
    }
    /// <summary>
    /// 图片命名类型
    /// </summary>
    public enum PU_PIC_NAMING_TYPE_E
    {
        PU_PIC_NAMING_TYPE_NO = 0,
        PU_PIC_NAMING_TYPE_DEV_IP,
        PU_PIC_NAMING_TYPE_DEV_ID,
        PU_PIC_NAMING_TYPE_TIME,
        PU_PIC_NAMING_TYPE_PLATE_ID,
        PU_PIC_NAMING_TYPE_PLATE_COLOR,
        PU_PIC_NAMING_TYPE_LANE_ID,
        PU_PIC_NAMING_TYPE_VEHICLE_TYPE,
        PU_PIC_NAMING_TYPE_VEHICLE_COLOR,
        PU_PIC_NAMING_TYPE_ROAD_ID,
        PU_PIC_NAMING_TYPE_DIR_ID,
        PU_PIC_NAMING_TYPE_DIR,
        PU_PIC_NAMING_TYPE_CUSTOM,
        PU_PIC_NAMING_TYPE_PLATE_TYPE,
        PU_PIC_NAMING_TYPE_VEHICLE_BRAND,
        PU_PIC_NAMING_TYPE_SUB_BRAND,
        PU_PIC_NAMING_TYPE_YEAR,
        PU_PIC_NAMING_TYPE_OBJ_ID,
        PU_PIC_NAMING_TYPE_VEHICLE_SIZE,
        PU_PIC_NAMING_TYPE_REGULATION_NUM,
        PU_PIC_NAMING_TYPE_PIC_NUM,
        PU_PIC_NAMING_TYPE_VEHICLE_DIRECTION,
        PU_PIC_NAMING_TYPE_VEHICLE_SPEED,
        PU_PIC_NAMING_TYPE_VERSION,
        PU_PIC_NAMING_TYPE_VEHICLE_RECT,
        PU_PIC_NAMING_TYPE_PLATE_RECT,
        PU_PIC_NAMING_TYPE_VEHICLE_BRAND_ID,
        PU_PIC_NAMING_TYPE_SUB_BRAND_ID,
        PU_PIC_NAMING_TYPE_GENDER,
        PU_PIC_NAMING_TYPE_AGE,
        PU_PIC_NAMING_TYPE_EXPRESSION,
        PU_PIC_NAMING_TYPE_GLASESS,
        PU_PIC_NAMING_TYPE_MOUTHMASK,
        PU_PIC_NAMING_TYPE_AGEGROUP,
        PU_PIC_NAMING_TYPE_SHAPE,
        PU_PIC_NAMING_TYPE_HAIR,
        PU_PIC_NAMING_TYPE_UMBRELLA,
        PU_PIC_NAMING_TYPE_BACKPACK,
        PU_PIC_NAMING_TYPE_FRONTPACK,
        PU_PIC_NAMING_TYPE_SATCHEL,
        PU_PIC_NAMING_TYPE_LUGGAGE,
        PU_PIC_NAMING_TYPE_CARRY,
        PU_PIC_NAMING_TYPE_MOVESPEED,
        PU_PIC_NAMING_TYPE_MOVEDIRECT,
        PU_PIC_NAMING_TYPE_UPPERTEXTURE,
        PU_PIC_NAMING_TYPE_UPPERSTYLE,
        PU_PIC_NAMING_TYPE_UPPERCOLOR,
        PU_PIC_NAMING_TYPE_LOWERSTYLE,
        PU_PIC_NAMING_TYPE_LOWERCOLOR,
        PU_PIC_NAMING_TYPE_HUMANDEV_IP,
        PU_PIC_NAMING_TYPE_HUMANTIME,
        PU_PIC_NAMING_TYPE_HUMANOBJ_ID,
        PU_PIC_NAMING_TYPE_HUMANCUSTOM,
        PU_PIC_NAMING_TYPE_RIDERMAN_GENDER = 80,
        PU_PIC_NAMING_TYPE_RIDERMAN_AGE, //骑行人年龄
        PU_PIC_NAMING_TYPE_RIDERMAN_UPPERSTYLE, //骑行人上衣款式
        PU_PIC_NAMING_TYPE_RIDERMAN_UPPERCOLOR, //骑行人上衣颜色
        PU_PIC_NAMING_TYPE_RIDERMAN_HELMET, // 头盔
        PU_PIC_NAMING_TYPE_RIDERMAN_HELMETCOLOR, // 头盔颜色
        PU_PIC_NAMING_TYPE_RIDERMAN_OBJID, // 骑行人追踪ID
        PU_PIC_NAMING_TYPE_RIDERMAN_IP, // 骑行人设备ip
        PU_PIC_NAMING_TYPE_RIDERMAN_TIME, //骑行人时间
        PU_PIC_NAMING_TYPE_RIDERMAN_CUSTOM, //骑行人自定义 
        PU_PIC_NAMING_TYPE_MAX,
    }
    /// <summary>
    /// FTP方式，VHD和机非人不同
    /// </summary>
    public enum PU_FTP_TYPE_E
    {
        PU_VHD_FTP,
        PU_BAYONET_FTP,
        PU_ITS_FTP,
        PU_COMMON_FTP,
        PU_IBALL_FTP,
        PU_EAST_SOFT_FTP,
        PU_HUMANFACE_FTP,
        PU_VEHFACEMIX_FTP,
        PU_FTP_TYPE_MAX,
    }
    /// <summary>
    /// FTP上传目录命名类型
    /// </summary>
    public enum PU_VLPR_FTP_DIR_NAMING_TYPE_E
    {
        VLPR_FTP_DIR_NAMING_TYPE_DEV_IP = 0, //设备IP
        VLPR_FTP_DIR_NAMING_TYPE_DEV_ID,     //设备ID
        VLPR_FTP_DIR_NAMING_TYPE_TIME_YM,    //时间(年月)
        VLPR_FTP_DIR_NAMING_TYPE_TIME_YMD,   //时间(年月日)
        VLPR_FTP_DIR_NAMING_TYPE_DIR,        //方向   
        VLPR_FTP_DIR_NAMING_TYPE_LANE_ID,    //车道号
        VLPR_FTP_DIR_NAMING_TYPE_CUSTOM,     //自定义
        VLPR_FTP_DIR_NAMING_TYPE_CHANNEL,	 // 通道号
        VLPR_FTP_DIR_NAMING_TYPE_REGULATION, // 违章类型
        VLPR_FTP_DIR_NAMING_TYPE_HOSTSLAVE_IP,//主从机IP
        VLPR_FTP_DIR_NAMING_TYPE_DEV_IP_ONE,  //网口1IP
        VLPR_FTP_DIR_NAMING_TYPE_DEV_IP_TWO,  //网口2IP
        VLPR_FTP_DIR_NAMING_TYPE_INTELLIGENT, // 智能分类
    }
    /// <summary>
    /// 外置灯类型
    /// </summary>
    public enum PU_EXT_LAMP_TYPE_E
    {
        PU_EXPOSURE_LAMP,     // 曝闪灯
        PU_STROBE_LAMP,       // 频闪灯
    }
    /// <summary>
    /// 曝光灯触发电平
    /// </summary>
    public enum PU_EXP_LAMP_TRIG_LEVEL_E
    {
        PU_TRIG_HIGH_LEVEL,    // 高电平触发
        PU_TRIG_LOW_LEVEL,     // 低电平触发
    }
    /// <summary>
    /// 频闪灯频率
    /// </summary>
    public enum PU_EXT_LAMP_FREQ_E
    {
        PU_FREQ_50 = 0,    /* 50hz*/
        PU_FREQ_60,        /* 60hz*/
        PU_FREQ_100,       /* 100hz*/
        PU_FREQ_120,       /* 120hz*/
    }

    /// <summary>
    /// 降噪模式
    /// </summary>
    public enum PU_DENOISE_MODE_E
    {
        DENOISE_NORMOL = 0,               //普通模式
        DENOISE_CLOSE,                    //关闭降噪
        DENOISE_EXPERT,                   //专家模式
        DENOISE_MAX
    }
    /// <summary>
    /// 镜头类型
    /// </summary>
    public enum PU_LENS_TYPE_E
    {
        PU_LENS_TYPE_SA = 0,           //Fuji lens(DV3.4x3.8SA-SA1L)
        PU_LENS_TYPE_SE                //Fuji lens(D8x7.8A-SE2N) 
    }
    /// <summary>
    /// ISP场景类型
    /// </summary>
    public enum PU_ISP_SCENE_TYPE_E
    {
        ISP_SCNEN_NORMAL = 0,  //通用场景
        ISP_SCENE_OBJECT,           // 客观场景，用于型检
        ISP_SCENE_INDOOR,               // 室内场景
        ISP_SCENE_OUTDOOR,              // 室外场景
        ISP_SCENE_LOW_BRIGHT,           // 低照场景
        ISP_SCENE_BACK_LIGHT,           // 背光场景
        ISP_SCENE_VIRTUAL_BAYONET,      // 虚拟卡口场景
        ISP_SCENE_FOG,                  // 雾天场景
        ISP_SCENE_FACE,                 // 人脸应用场景 (当前针对人脸相机增加, 后续考虑是否增加应用模式修改
        ISP_SCENE_MAX
    }
    /// <summary>
    /// 昼夜模式
    /// </summary>
    public enum PU_VIDEO_BLACKWHITE_MODE_E
    {
        PU_VIDEO_MODE_AUTO = 0,    //自动模式
        PU_VIDEO_MODE_COLOR,       //彩色模式
        PU_VIDEO_MODE_GRAY,        //黑白模式
        PU_VIDEO_MODE_NEGART
    }
    /// <summary>
    /// 智能升级包类型
    /// </summary>
    public enum PU_UPGRADE_ITGT_TYPE_E
    {
        PU_UPGRADE_ITGT_TYPE_APP = 0,         //APP包
        PU_UPGRADE_ITGT_TYPE_FACE_BODY_DETECT = 1,         //人脸人体检测算法包
        PU_UPGRADE_ITGT_TYPE_FACE_RECOGTION = 2,         //人脸识别算法包
        PU_UPGRADE_ITGT_TYPE_ILLEG_PARK_DETECT = 4,         //违停检测算法包
        PU_UPGRADE_ITGT_TYPE_OBJ_CLASSIFICATION = 8,         //机非人车牌检测算法包
        PU_UPGRADE_ITGT_TYPE_NON_CHINA_VEHICLE_RECOGTION = 16,        //海外车牌检测算法包
        PU_UPGRADE_ITGT_TYPE_SCENE_ADAPTATION = 32,        //场景自适应算法包
        PU_UPGRADE_ITGT_TYPE_QUEUE_LENTH_CROWD_COUNT,                //排队长度人群密度估计算法包
        PU_UPGRADE_ITGT_3RD_TYPE_APP = 64,                         //三方APP包
        PU_UPGRADE_LET_4G_MODEL,                                   //4G软件包
        PU_UPGRADE_DCHIP_TYPE_APP,                                 //D芯片升级包，设备要重启
        PU_UPGRADE_DCHIP_TYPE_ALG,                                 //D芯片算法包
        PU_UPGRADE_EBI_TYPE_APP,                                   //BEI周界专用款型算法包
        PU_UPGRADE_ITGT_TYPE_OMNI,                                 //星图算法包，用于机非人和人脸检测
        PU_UPGRADE_TYPE_MAX = 127                                 //升级包类型最大值
    }
    /// <summary>
    /// 设备操作类型
    /// </summary>
    public enum PU_DEV_OPT_E
    {
        PU_DEV_OPT_TYPE_REBOOT = 0,         // 重启
        PU_DEV_OPT_TYPE_FORMAT = 1,         //格式化磁盘
        PU_DEV_OPT_TYPE_MAX
    }
    /// <summary>
    /// 人脸库操作类型
    /// </summary>
    public enum PU_FACELIB_OPERATE_E
    {
        FACELIB_ADD = 1,
        FACELIB_MODIFY,
        FACELIB_DEL,
        FACELIB_DEL_ALL,
        FACELIB_MAX,
    }
    /// <summary>
    /// 人脸库名单类型
    /// </summary>
    public enum PU_FACE_LIB_TYPE_E
    {
        FACE_LIB_DEFAULT = 0,
        FACE_LIB_BLACK,
        FACE_LIB_WHITE,
        FACE_LIB_MAX,
    }
    /// <summary>
    /// 人员性别
    /// </summary>
    public enum PU_GENDER_E
    {
        PU_GENDER_ALL = -1,    // 全部：搜索时专用，添加、修改时禁止
        PU_MALE = 0,
        PU_FEMALE,
        PU_GENDER_UNKNOW,// 未知
        PU_GENDER_MAX,
    }
    /// <summary>
    /// 人员证件类型
    /// </summary>
    public enum PU_CARDTYPE_E
    {
        CARDTYPE_ALL = -1,  // 全部：搜索时专用，添加、修改时禁止
        IDENTITY = 0,
        PASSPORT,
        OFFICER,
        DRIVING,
        OTHERS,
        MAX
    }
    /// <summary>
    /// licence文件上传类型
    /// </summary>
    public enum PU_LICENCE_UPLOAD_TYPE_E
    {
        PU_LICENCE_ITGT_UPLOAD_TYPE = 0,
        PU_LICENCE_OTHER_UPLOAD_TYPE,
        PU_LICENCE_UPLOAD_TYPE_MAX
    }
    /// <summary>
    /// 智能算法种类
    /// </summary>
    public enum PU_ITGT_TYPE_E
    {
        PU_ITGT_TYPE_FACE_BODY_DETECT = 1,            //人脸人体检测 Face and body detection
        PU_ITGT_TYPE_FACE_RECOGTION,                  //人脸识别Facial recognition
        PU_ITGT_TYPE_ILLEG_PARK_DETECT,               //违停检测Illegal parking detection
        PU_ITGT_TYPE_OBJ_CLASSIFICATION,              //机非人车牌检测Object classification
        PU_ITGT_TYPE_VLPR_VEH_RECOGTION,              //车牌算法检测License plate algorithm
                                                      //recognition，收编海外车牌、国内/印尼车牌检测      
        PU_ITGT_TYPE_SCENE_ADAPT_FOG,                 //透雾自适应Fog scene adaptive
        PU_ITGT_TYPE_SCENE_ADAPT_SPEED,               //拖影自适应speed scene adaptive
        PU_ITGT_TYPE_SCENE_ADAPT_BACK_LIGHT,          //背光自适应Backlight scene adaptive
        PU_ITGT_TYPE_FACE_ATTRIBUTE,                  //人脸属性 face attribute
        PU_ITGT_TYPE_BODY_ATTRIBUTE,                  //人体属性 body attribute
        PU_ITGT_TYPE_QUEUE_DETECT,                    //排队检测 queue detect
        PU_ITGT_TYPE_CROWD_DENSITY_DETECITON,         //人群密度检测  crowd density detection
        PU_ITGT_TYPE_CHINA_INDO_VEH_RECOGTION,        //国内/印尼车牌 Chn & Indo vehicle recognition
        PU_ITGT_TYPE_STRATEGY_MMC,                    //多机协同 multi-cooperation
        PU_ITGT_TYPE_STRATEGY_YTN,                    //一拖N组网
        PU_ITGT_TYPE_STRATEGY_ONLINELEARNING,          //在线自学习
        PU_ITGT_TYPE_STRATEGY_PORTTRAIT_VALUE_BASIC,   //人像基础
        PU_ITGT_TYPE_STRATEGY_PORTTRAIT_VALUE_ENHANCED,//人像增强
        PU_ITGT_TYPE_STRATEGY_VEHICLE_VALUE_BASE,      //车辆基础
        PU_ITGT_TYPE_STRATEGY_VEHICLE_VALUE_enhanced,  //车辆增强
        PU_ITGT_TYPE_STRATEGY_BEHAVIOR_ANALYSIS,       //行为分析态势
        PU_GB35114SW,                                  //GB35114软件SDK License
        PU_ITGT_TYPE_EBI_TYPE,                         //BEI周界专用款型
        PU_ITGT_TYPE_MAX
    }
    /// <summary>
    /// 智能算法license控制状态
    /// </summary>
    public enum PU_ITGT_LIC_STATUS_E
    {
        PU_ITGT_LIC_STATUS_DEFAULT = 0,  //控制项处于默认状态
        PU_ITGT_LIC_STATUS_TRIAL,        //控制项处于宽限期状态
        PU_ITGT_LIC_STATUS_NORMAL,       //控制项处于正常状态
        PU_ITGT_LIC_STATUS_EMERGENCY,    //控制项处于紧急状态
        PU_ITGT_LIC_STATUS_NO_USE        //不使用
    }
    /// <summary>
    /// 三方APP枚举
    /// </summary>
    public enum PU_VW_OPERATE_3RD_APP_TYPE
    {
        PU_OPERATE_3RD_APP_START = 0,
        PU_OPERATE_3RD_APP_STOP,
        PU_OPERATE_3RD_APP_UNINSTALL,
        PU_OPERATE_3RD_APP_MAX
    }
    /// <summary>
    /// DIAL_MODE_E
    /// </summary>
    public enum DIAL_MODE_E
    {
        MANUL_DIAL = 0,
        AUTO_DIAL,
        DIAL_MAX
    }
    /// <summary>
    /// 网络类型
    /// </summary>
    public enum WIRELESS_NET_MODE_E
    {
        WL_NET_TYPE_AUTO = 0,
        WL_NET_TYPE_4G,
        WL_NET_TYPE_3G,
        WL_NET_TYPE_MAX
    }
    /// <summary>
    /// 鉴权类型
    /// </summary>
    public enum DIAL_AUTH_TYPE_E
    {
        DIAL_AUTH_NONE = 0x00,
        DIAL_AUTH_PAP = 0x01,
        DIAL_AUTH_CHAP = 0x02,
        DIAL_AUTH_CHAP_PAP = 0x03
    }
    /// <summary>
    /// 使能类型
    /// </summary>
    public enum PU_ENABLE_TYPE_E
    {
        PU_ENABLE_FALSE = 0,
        PU_ENABLE_TRUE = 1,
        PU_ENABLE_MAX
    }
    /// <summary>
    /// SIM卡状态类型
    /// </summary>
    public enum DIAL_SIM_STATUS_TYPE_E
    {
        DIAL_SIM_STATUS_ABSENT = 0,          /*无卡状态*/
        DIAL_SIM_STATUS_READY,               /*卡状态正常状态*/
        DIAL_SIM_STATUS_FAILURE,             /*卡状态异常*/
        DIAL_SIM_STATUS_PIN_REQUIRED,        /*待输入PIN码解锁*/
        DIAL_SIM_STATUS_PIN2_REQUIRED,       /*待输入PIN2码解锁*/
        DIAL_SIM_STATUS_PUK_REQUIRED,        /*待输入PUK码解锁*/
        DIAL_SIM_STATUS_PUK2_REQUIRED,       /*待输入PUK2码解锁*/
        DIAL_SIM_STATUS_OPERATION_NOT_ALLOW, /*操作不允许*/
        DIAL_SIM_STATUS_INCORRECT_PASSWORD,  /*密码错误*/
        DIAL_SIM_STATUS_PIN_ERROR_MAX
    }
    /// <summary>
    /// 网络拨号类型
    /// </summary>
    public enum DIAL_NET_ACT_TYPE_E
    {
        DIAL_REGISTER_ST_NO_SERVICE = 0x00,
        DIAL_REGISTER_ST_GSM = 0x01,
        DIAL_REGISTER_ST_WCDMA = 0x02,
        DIAL_REGISTER_ST_LTE = 0x03,
        DIAL_REGISTER_ST_MAX
    }
    /// <summary>
    /// 注册状态
    /// </summary>
    public enum DIAL_REGIST_STATUS_E
    {
        DIAL_REGISTER_STAT_NOT_REGISTER = 0x00,
        DIAL_REGISTER_STAT_HOME_REGISTERD = 0x01,
        DIAL_REGISTER_STAT_SEARCHING = 0x02,
        DIAL_REGISTER_STAT_DENIED = 0x03,
        DIAL_REGISTER_STAT_UNKNOWN = 0x04,
        DIAL_REGISTER_STAT_ROAMING_REGISTER = 0x05,
        DIAL_REGISTER_STAT_MAX
    }
    /// <summary>
    /// 拨号连接
    /// </summary>
    public enum DIAL_CONNECT_E
    {
        DIAL_DISCONNECT = 0,
        DIAL_CONNECT,
        DIAL_CONNECT_MAX
    }
    /// <summary>
    /// 图片合成类型
    /// </summary>
    public enum PU_COMBINE_TYPE_E
    {
        PU_COMB_SIGNEL_NOROI, /* 抓拍一张无特写 */
        PU_COMB_SIGNEL_HOR, /* 一张抓拍，原图加特写，水平合成 */
        PU_COMB_SIGNEL_VER, /* 一张抓拍，原图加特写，垂直合成 */
        PU_COMB_DOUBLE_HOR_NOROI, /* 抓拍两张无特写，水平合成 */
        PU_COMB_DOUBLE_VER_NOROI, /* 抓拍两张无特写，垂直合成 */
        PU_COMB_DOUBLE_HOR, /* 两张抓拍，原图加特写，水平合成 */
        PU_COMB_DOUBLE_VER, /* 两张抓拍，原图加特写，垂直合成 */
        PU_COMB_DOUBLE_PYRAMIDAL_TOP, /* 两张抓拍，原图加特写，品字形合成 */
        PU_COMB_DOUBLE_PYRAMIDAL_BUTT, /* 两张抓拍，原图加特写，倒品字形合成 */
        PU_COMB_DOUBLE_PYRAMIDAL_LEFT, /* 两张抓拍，原图加特写，品字形头朝左合成 */
        PU_COMB_DOUBLE_PYRAMIDAL_RIGHT, /* 两张抓拍，原图加特写，品字形头朝右合成 */
        PU_COMB_TREBLE_HOR_NOROI, /* 抓拍三张无特写，水平合成 */
        PU_COMB_TREBLE_VER_NOROI, /* 抓拍三张无特写，垂直合成 */
        PU_COMB_TREBLE_HOR, /* 三张抓拍，原图加特写，水平合成 */
        PU_COMB_TREBLE_VER, /* 三张抓拍，原图加特写，垂直合成 */
        PU_COMB_TREBLE_PYRAMIDAL_TOP, /* 三张抓拍，原图加特写，品字形合成 */
        PU_COMB_TREBLE_PYRAMIDAL_BUTT, /* 三张抓拍，原图加特写，倒品字形合成 */
        PU_COMB_TREBLE_PYRAMIDAL_LEFT, /* 三张抓拍，原图加特写，品字形头朝左合成 */
        PU_COMB_TREBLE_PYRAMIDAL_RIGHT, /* 三张抓拍，原图加特写，品字形头朝右合成 */
        PU_COMB_TREBLE_SQUARE, /* 三张抓拍，原图加特写，田字形合成 */
        PU_COMB_TREBLE_SQUARE_NOROI,   /*抓拍四张无特写，田字形合成*/

        PU_COMB_SIX_IN_ONE_HOR,   /* ITS电警6合1，横条，框*3 高*2 */
        PU_COMB_SIX_IN_ONE_VER,   /* ITS电警6合1，竖条，框*2 高*3 */

        //若需新增1张合成方式枚举值，从50开始

        //新增2张合成方式枚举值，从100开始
        PU_COMB_DOUBLE_PYRAMIDAL_TOP_ADAPT = 100, /* 两张抓拍，原图加特写，品字形合成调整大小 */
        PU_COMB_DOUBLE_PYRAMIDAL_BUTT_ADAPT, /* 两张抓拍，原图加特写，倒品字形合成调整大小 */
        PU_COMB_DOUBLE_PYRAMIDAL_LEFT_ADAPT, /* 两张抓拍，原图加特写，品字形头朝左合成调整大小 */
        PU_COMB_DOUBLE_PYRAMIDAL_RIGHT_ADAPT, /* 两张抓拍，原图加特写，品字形头朝右合成 调整大小*/

        //新增3张合成方式枚举值，从150开始
        PU_COMB_TREBLE_PYRAMIDAL_TOP_ADAPT = 150, /* 三张抓拍，无特写，品字形合成 调整大小 */
        PU_COMB_TREBLE_PYRAMIDAL_BUTT_ADAPT, /* 三张抓拍，无特写，倒品字形合成调整大小  */
        PU_COMB_TREBLE_PYRAMIDAL_LEFT_ADAPT, /* 三张抓拍，无特写，品字形头朝左合成调整大小  */
        PU_COMB_TREBLE_PYRAMIDAL_RIGHT_ADAPT, /* 三张抓拍，无特写，品字形头朝右合成调整大小  */
        PU_COMB_TREBLE_BUTT,
    }
    /// <summary>
    /// 图片合成属性
    /// </summary>
    public enum PU_COMBINE_IMG_ROI_E
    {
        PU_COMBINE_IMG0_ORI, /* 第0张抓拍原图 */
        PU_COMBINE_IMG0_ROI, /* 第0张抓拍抠图, 不支持 */
        PU_COMBINE_IMG1_ORI, /* 第1张抓拍原图 */
        PU_COMBINE_IMG1_ROI, /* 第1张抓拍抠图，不支持*/
        PU_COMBINE_IMG2_ORI, /* 第2张抓拍原图 */
        PU_COMBINE_IMG2_ROI, /* 第2张抓拍抠图，不支持 */
        PU_COMBINE_IMG3_ORI, /* 第3张抓拍原图 */
        PU_COMBINE_IMGS_ROI, /* 特写图，具体哪张的特写图由智能定*/

        PU_COMB_IMG_GW_ORI, /* 6合1卡口抓拍原图 */
        PU_COMB_IMG_GW_ROI, /* 6合1卡口抓拍特写图 */
        PU_COMBINE_IMG_BUTT,
    }
    /// <summary>
    /// 图片合成尺寸
    /// </summary>
    public enum PU_COMBINE_SCALE_E
    {
        PU_COMB_SIZE_ORG,//原图尺寸
        PU_COMB_SIZE_QUARTER, //四分之一
        PU_COMB_SIZE_RESERVE,
    }
    /// <summary>
    /// 报警上报等级
    /// </summary>
    public enum PU_ALARM_LEVEL_E
    {
        PU_ALARM_LEVEL_INFO,      // 提示
        PU_ALARM_LEVEL_GENERAL,   //一般
        PU_ALARM_LEVEL_CRITICAL,  //严重
        PU_ALARM_LEVEL_FATAL,     //致命
        PU_ALARM_LEVEL_MAX
    }
    /// <summary>
    /// 设备配置参数
    /// </summary>
    public enum PU_DEV_CONFIG_TYPE_E
    {
        PU_DEV_CONFIG_TYPE_IP_FILTER,              //IP 过滤
        PU_DEV_CONFIG_TYPE_DEV_PORT,               //设备端口
        PU_DEV_CONFIG_TYPE_TCP_ACCELERATE,         //网络智能加速
        PU_DEV_CONFIG_TYPE_DDNS,                   //DDNS
        PU_DEV_CONFIG_TYPE_802DOT1x,               //802.1x
        PU_DEV_CONFIG_TYPE_SSH,                    //SSH
        PU_DEV_CONFIG_TYPE_SFTP,                   //SFTP
        PU_DEV_CONFIG_TYPE_SNMP_COMMUNITY,         // SNMPv1v2c社团列表
        PU_DEV_CONFIG_TYPE_SNMPV3_USER_MANAGE,     // SNMP v3用户管理
        PU_DEV_CONFIG_TYPE_SNMPV3_USER,            // SNMP v3用户列表
        PU_DEV_CONFIG_TYPE_SNMPV3_TRAP,            //SNMP Trap接收方列表
        PU_DEV_CONFIG_TYPE_MAX
    }
    /// <summary>
    /// 车辆类型
    /// </summary>
    public enum PU_VEHICLE_TYPE_E
    {
        PU_LPR_VT_NOT,          //未知
        PU_LPR_VT_CAR,          //轿车
        PU_LPR_VT_TRUCK,        //货车
        PU_LPR_VT_VAN,          //面包车
        PU_LPR_VT_PAS,          //客车
        PU_LPR_VT_BUGGY,        //小货车
        PU_LPR_VT_SUV,          //SUV
        PU_LPR_VT_MEDIUM_BUS,   //中型客车
        PU_LPR_VT_MOT,          //摩托车（非机动车）
        PU_LPR_VT_PEDESTRAIN,   //行人
        PU_LPR_VT_SCHOOL_BUS,   //校车
        PU_LPR_VT_HEAVY_TRUCK,  //泥头车
        PU_LPR_VT_TANKER,       //高危车
        PU_LPR_VT_RIDEMAN, //骑行人 占位
        //=================以上是老版本支持
        PU_VLPR_VT_CAR_M,       //微型轿车
        PU_VLPR_VT_CAR_L,          //小型轿车
        PU_VLPR_VT_CAR_S,          //紧凑型轿车
        PU_VLPR_VT_CAR_TWO,        //两厢轿车
        PU_VLPR_VT_CAR_THR,        //三厢轿车
        PU_VLPR_VT_SUV_QINGKE,     //轻客
        PU_VLPR_VT_SUV_L,          //小型SUV
        PU_VLPR_VT_SUV_S,          //紧凑型SUV
        PU_VLPR_VT_SUV_Z,          //中型SUV
        PU_VLPR_VT_SUV_M,          //中大型SUV      
        PU_VLPR_VT_SUV_B,          //大型SUV
        PU_VLPR_VT_WEIMIAN,     //微型面包车

        PU_VLPR_VT_MPV,         //MPV
        PU_VLPR_VT_JP,              //轿跑

        PU_VLPR_VT_WEIKA,           //微卡
        PU_VLPR_VT_SUV_PIKA,       //皮卡
        PU_VLPR_VT_TRUCK_Z,        //中卡
        PU_VLPR_VT_TRUCK_KEI,      //轻卡
        PU_VLPR_VT_ZHONGKA,     //重卡

        PU_VLPR_VT_TAXI, //出租车 
        PU_VLPR_VT_TANK, //油罐车
        PU_VLPR_VT_CRANE, //吊车
        PU_LPR_VT_ALL = 512     //全部
    }
    /// <summary>
    /// 违章类型
    /// </summary>
    public enum PU_ITS_REGULA_TYPE_E
    {
        ITS_REGULA_NULL = 0, /* 无违章判断, 初始值 */
        ITS_REGULA_PASS_SNAP = 1, /* 卡口抓拍 */
        ITS_REGULA_RUNNINGRED = 2, /* 闯红灯     1625*/
        ITS_REGULA_EXCEET_SPEED = 3, /* 超速 */
        ITS_REGULA_UNDER_SPEED = 4, /* 低速    4306*/
        ITS_REGULA_WRONG_DIRECTION = 5, /* 不按导向行驶, 左转/直行/右转 1208*/
        ITS_REGULA_REVERSE_DIRECTION = 6, /* 逆行 1301  */
        ITS_REGULA_LICENCE_RESTRICTE = 7, /* 尾号限行 */
        ITS_REGULA_OVER_LANE_LINE = 8, /* 压车道线 1345*/
        ITS_REGULA_CHANGE_LANE = 9, /* 违法变道 13453*/
        ITS_REGULA_MOTOR_IN_BICYCLE_LANE = 10, /* 机占非 1018*/
        ITS_REGULA_ACCOMMODATION_LANE = 11, /* 占用专用车道  1019*/
        ITS_REGULA_PROHIBITION = 12, /* 闯禁令 1344*/
        ITS_REGULA_REMAIN_CROSS = 13, /* 路口滞留 1228*/
        ITS_REGULA_STOP_LIGHT_GREEN = 14, /* 绿灯停车 16251*/
        ITS_REGULA_EMERGENCY = 15, /* 占用应急车道   */
        ITS_REGULA_SAFETY_BELT = 16, /* 未系安全带 1240*/
        ITS_REGULA_U_TURN = 17, /* 违章掉头 1044*/
        ITS_REGULA_PORT_VEHICLE_DRIVER_CALL = 18,  /* 主驾驶打电话 卡口设备触发*/
        ITS_REGULA_PORT_VEHICLE_COPILOT_NO_BELT = 19,  /* 副驾驶未系安全带 卡口设备触发*/
        ITS_REGULA_PORT_VEHICLE_NO_YEAR_LOG = 20,  /* 无年检标 卡口设备触发*/
        ITS_REGULA_ILLEGAL_PARKING = 21,        /*黄网格违停*/
        ITS_REGULA_IMPOLITE_PEDESTRIANS = 22, /*不礼让行人*/
        ITS_REGULA_OCCUPANCY_BUSLANE = 23, /*违法占用公交车道*/
        ITS_REGULA_LARGER_VEHICLE_OUTOFLANE = 24, /*大车不按车道行驶*/
        ITS_REGULA_IBALL_ILLEGAL_PARKING = 25,   /*违法停车*/
        ITS_REGULA_VEHICLEBAN = 26, /*闯禁令*/
        ITS_REGULA_NOVEHICLE_IN_LANE = 27, /*非占机*/
        ITS_REGULA_PED_RUN_RED = 28, /*行人闯红灯*/
        ITS_REGULA_RECOGNIZE_ONLY = 30,          /* 电警六合一,车流量等只需识别不需上传元数据的用此枚举 */
        ITS_REGULA_ALL = 31,               /* 内核栈空间最大只支持32个违章 */
        ITS_REGULA_BUTT = 32,
    }
    /// <summary>
    /// 违章类型检测方式
    /// </summary>
    public enum EN_ITS_REGULA_DT_TYPE
    {
        ITS_REGULA_DT_TYPE_EXTDEV,          // 外设接入
        ITS_REGULA_DT_TYPE_VIDEODT,         // 视频检测
        ITS_REGULA_DT_TYPE_EXTDEV_FIRST,    // 外设优先
        ITS_REGULA_DT_TYPE_MAX
    }
    /// <summary>
    /// 抓拍时间间隔检测方式
    /// </summary>
    public enum PU_ITS_SNAP_INTERVAL_TYPE
    {
        PU_ITS_SNAP_INTERVAL,                  // 固定抓拍间隔
        PU_ITS_ADAPTIVE_SNAP_INTERVAL,         // 自适应抓拍间隔
        PU_ITS_SNAP_INTERVAL_TYPE_MAX
    }
    /// <summary>
    /// ITS应用模式类型
    /// </summary>
    public enum EN_ITS_TYPE
    {
        ITS_TYPE_EPOLICE = 0,       //电警
        ITS_TYPE_TGATEWAY = 1,      //卡口
        ITS_TYPE_IBALL = 2,         //违停球(违章球)	暂不支持
        ITS_TYPE_PASSAGEWAY = 3,    //出入口
        ITS_TYPE_VLPR = 4,          //微卡                  暂不支持
        ITS_TYPE_PEDRUNRED = 5,        //行人闯红灯
        ITS_TYPE_MAX,
    }
    /// <summary>
    /// 方向编号
    /// </summary>
    public enum PU_ITS_ROAD_DIR_TYPE_E
    {
        ITS_ROAD_UNKNOW,         // 未知
        ITS_ROAD_EAST_TO_WEST,   // 东向西
        ITS_ROAD_WEST_TO_EAST,   // 西向东
        ITS_ROAD_SOUTH_TO_NORTH, // 南向北
        ITS_ROAD_NORTH_TO_SOUTH, // 北向南
        ITS_ROAD_ES_TO_WN,       // 东南向西北
        ITS_ROAD_WN_TO_ES,       // 西北向东南
        ITS_ROAD_EN_TO_WS,       // 东北向西南
        ITS_ROAD_WS_TO_EN        // 西南向东北
    }
    /// <summary>
    /// 车道线行驶方向
    /// </summary>
    public enum PU_ITS_ROAD_DRV_DIR_E
    {
        ITS_ROAD_DRV_DIR_UNKNOW,           // 未知
        ITS_ROAD_DRV_DIR_LEFT,             // 左转
        ITS_ROAD_DRV_DIR_STRAIGHT,         // 直行
        ITS_ROAD_DRV_DIR_LFT_STR,          // 左转+直行
        ITS_ROAD_DRV_DIR_RIGHT,            // 右转
        ITS_ROAD_DRV_DIR_RHT_LFT,          // 右转+左转
        ITS_ROAD_DRV_DIR_RHT_STR,          // 右转+直行
        ITS_ROAD_DRV_DIR_RHT_STR_LFT,      // 右转+左转+直行
        ITS_ROAD_DRV_DIR_LFT_WAIT          // 左转待行
    }
    /// <summary>
    /// 车辆在视频中的运动方向
    /// </summary>
    public enum PU_ITS_CAR_DRV_DIR_E
    {
        ITS_CAR_UNKNOW,             // 未知
        ITS_CAR_BOTTOM_TO_TOP,      // 从下向上
        ITS_CAR_TOP_TO_BOTTOM,      // 从上向下
    }
    /// <summary>
    /// 车道用途
    /// </summary>
    public enum PU_ITS_ROAD_PURPOSE_E
    {
        ITS_UNKNOW_ROAD,             // 未知车道
        ITS_COMMON_ROAD,             // 普通车道
        ITS_BUS_ROAD,                // 公交车道
        ITS_FAST_ROAD,               // 快车道
        ITS_SLOW_ROAD,               // 慢车道
        ITS_MOTOR_ROAD,              // 摩托车道
        ITS_NONMOTOR_ROAD,           // 非机动车道
        ITS_REVERSE_ROAD,            // 反向车道
        ITS_FORBIT_BIGCAR_ROAD,       // 禁止大车道
        ITS_EMERGENCY                // 应急车道
    }
    /// <summary>
    /// 车道属性
    /// </summary>
    public enum PU_ITS_ROAD_ATTRIBUTE_E
    {
        ITS_ROAD_HIGHWAY,       // 高速公路
        ITS_ROAD_EXPRESSWAY,    // 城市快速路
        ITS_ROAD_OTHER,         // 其他道路
    }
    /// <summary>
    /// 车道旁边场景类型
    /// </summary>
    public enum ITS_ROAD_SIDE_SCENE_E
    {
        ITS_MEDIAN_ROAD_SIDE,             // 隔离带类型
        ITS_REALLINE_ROAD_SIDE,           // 实线类型
        ITS_DOTLINE_ROAD_SIDE,            // 虚线类型
        ITS_UNKNOWN_ROAD_SIDE = 10             //未知场景类型
    }
    /// <summary>
    /// 红绿灯接入方式
    /// </summary>
    public enum PU_ITS_LIGHT_DT_TYPE_S
    {
        ITS_LIGHT_DT_TYPE_485,   // 485接入
        ITS_LIGHT_DT_TYPE_VIDEO, // 视频接入
        ITS_LIGHT_DT_TYPE_UNKNOW,
    }
    /// <summary>
    /// 信号灯方式
    /// </summary>
    public enum PU_ITS_LIGHT_ARRANGE_TYPE_E
    {
        ITS_LIGHT_ARRANGE_TYPE_BROADWISE, /* 横向 */
        ITS_LIGHT_ARRANGE_TYPE_ENDWISE,   /* 纵向 */
        ITS_LIGHT_ARRANGE_TYPE_UNKOWN,
    }
    /// <summary>
    /// 闯灯优先级
    /// </summary>
    public enum PU_ITS_RUNLIGHT_PRIORITY_E
    {
        ITS_RUNLIGHT_NONE_PRIORITY,     // 无
        ITS_RUNLIGHT_RED_PRIORITY,       // 闯红灯优先
    }
    /// <summary>
    /// 闯灯违规逻辑
    /// </summary>
    public enum PU_ITS_RUNLIGHT_RULE_E
    {
        ITS_RUNLIGHT_BYLANE,            // 按车道
        ITS_RUNLIGHT_BYDIR              // 按方向
    }
    /// <summary>
    /// 灯类型
    /// </summary>
    public enum PU_RL_LIGHT_TYPE_E
    {
        RL_TYPE_DISC = 1,                             //圆盘
        RL_TYPE_ARROW,                                //箭头
        RL_TYPE_NUMBER,                               //倒计时
        RL_TYPE_MAX,
    }
    /// <summary>
    /// 灯状态
    /// </summary>
    public enum PU_RL_LIGHT_STATUS_E
    {
        RL_STATUS_GREEN = 0,                             //绿灯
        RL_STATUS_RED,                                   //红灯
        RL_STATUS_MAX,
    }
    /// <summary>
    /// 信号灯导向
    /// </summary>
    public enum PU_RL_LIGHT_WAIT_TYPE_E
    {
        RL_TRAFFIC_LIGHT_WAIT_TURN_LEFT = 0x0,   //左转待行
        RL_TRAFFIC_LIGHT_WAIT_GO_STRAIGHT = 0x1,   //直行待行
        RL_TRAFFIC_LIGHT_WAIT_TURN_RIGHT = 0x2,   //右转待行
        RL_TRAFFIC_LIGHT_WAIT_TURN_ROUND = 0x3,    //掉头转弯待行

        RL_TRAFFIC_LIGHT_WAIT_BUTT
    }
    /// <summary>
    /// 图像镜像和旋转方式
    /// </summary>
    public enum VIDEO_VENC_ROTATION_E
    {
        VIDEO_ROTATION_NORMAL = 0,               //正常图像
        VIDEO_ROTATION_MIRROR,                   //左右镜像
        VIDEO_ROTATION_FILP,                     //上下
        VIDEO_ROTATION_BOTH,                     //上下左右
        VIDEO_ROTATION_MAX
    }
    /// <summary>
    /// 车道描述
    /// </summary>
    public enum LANE_DIRECTION_E
    {
        LANE_DIRECTION_DOWN, /* 向下运动 */
        LANE_DIRECTION_UP, /* 向上运动 */
        LANE_DIRECTION_UNDEF, /* 未定义运动方向, 无法判断逆行, 只有速度值 */
    }
    /// <summary>
    /// 描述提示类型
    /// </summary>
    public enum DERICTION_SIGN_TYPE_E
    {
        DERICTION_TYPE_LEFT, /* 左转 */
        DERICTION_TYPE_STRAIGHT, /* 直行 */
        DERICTION_TYPE_LEFT_STRAIGHT, /* 左转直行 */
        DERICTION_TYPE_RIGHT, /* 右转 */
        DERICTION_TYPE_LEFT_RIGHT, /* 左转右转 */
        DERICTION_TYPE_RIGHT_STRAIGHT, /* 右转直行 */
        DERICTION_TYPE_LEFT_RIGHT_STRAIGHT, /* 左转右转直行 */
        DERICTION_TYPE_LEFT_STAY, /* 左转待行 */
        DERICTION_TYPE_STRAIGHT_STAY, /* 直行待行 */
        DERICTION_TYPE_RIGHT_STAY, /* 右转待行 */
        DERICTION_TYPE_BUTT
    }
    /// <summary>
    /// 道路线条类型
    /// </summary>
    public enum ITS_ROAD_LINE_TYPE_E
    {
        ITS_ROAD_LINE_TYPE_WHITE_SOLOD,   /* 白实线 */
        ITS_ROAD_LINE_TYPE_WHITE_DOTTED,  /* 白虚线 */
        ITS_ROAD_LINE_TYPE_SINGLE_YELLOW, /* 单黄线 */
        ITS_ROAD_LINE_TYPE_DOUBLE_YELLOW, /* 双黄线 */
        ITS_ROAD_LINE_TYPE_GUARD_BAR,     /* 有护栏车道线 */
    }
    /// <summary>
    /// 定位框
    /// </summary>
    public enum PU_ITS_POS_BOX_TYPE_E
    {
        ITS_POS_BOX_TYPE_BIG,
        ITS_POS_BOX_TYPE_MID,
        ITS_POS_BOX_TYPE_SMALL
    }
    /// <summary>
    /// 智能数据类型
    /// </summary>
    public enum PU_AI_LEVEL_E
    {
        PU_AI_LEVEL_ONLY = 0,
        PU_AI_LEVEL_PU_PU,
    }
    /// <summary>
    /// 多机协同类型
    /// </summary>
    public enum PU_MMC_TYPE_E
    {
        PU_MMC_FACE_RECOG = 0,
        PU_MMC_MAX,
    }
    /// <summary>
    /// 多机协同名称
    /// </summary>
    public enum PU_AI_NAME_E
    {
        PU_PU_AI_SUBS = 0,   //订阅接口，针对入口SDC调用
        PU_PU_AI_TRANS_DATA, //转发接口
    }
    /// <summary>
    /// 设备类型
    /// </summary>
    public enum PU_DEVICE_MODE_E
    {
        EP_VIDEO_MODE = 0,        //视频电警
        GT_VIDEO_MODE,          //视频卡口
        ITS_MODE_MAX
    }
    /// <summary>
    /// 外设大类型
    /// </summary>
    public enum PU_ITS_EXTRA_DEVICE_TYPE_E
    {
        ITS_DEVICE_NONE,               //无外设
        ITS_DEVICE_RADAR,              //雷达外设
        ITS_DEVICE_VEHICLE,            //车检外设
        ITS_DEVICE_IO,                 //IO外设
    }
    /// <summary>
    /// IO触发方式
    /// </summary>
    public enum PU_DEVICE_IO_TYPE_E
    {
        DEVICE_IO_NONE,                //不触发
        DEVICE_IO_RISE,                //上升沿触发
        DEVICE_IO_DOWN,                //下降沿触发
        DEVICE_IO_BOTH,                //都触发
    }
    /// <summary>
    /// 检测器外设的类型
    /// </summary>
    public enum PU_EXTRA_DEVICE_TYPE_E
    {
        ITS_EQUIP_TYPE_INVALID = 0,
        ITS_EQUIP_RS485_RADAR_CSR_1K,       //北京川速公司的CSR-IK单车道雷达
        ITS_EQUIP_RS485_RADAR_CSR_IN,       //北京川速公司的CSR-IN单车道雷达
        ITS_EQUIP_RS485_RADAR_CSR_IM,       //北京川速公司的CSR-IM多车道雷达
        ITS_EQUIP_RS485_RADAR_MPR_LV,       //上海慧昌公司的MPR-LV流量雷达
        ITS_EQUIP_RS485_RADAR_HT_MTTR,      //802所HT-MTTR单车道雷达
        ITS_EQUIP_RS485_RADAR_STJ1,         //森思泰克STJ1单车道雷达
        ITS_EQUIP_RS485_COIL_TULI_PK600K = 100,   //上海图立公司的线圈车检器
        ITS_EQUIP_RS485_LIGHT_DTOR_TL01 = 200,  //北京信路威公司的红绿灯检测器
        ITS_EQUIP_IO = 300,    //IO协议
        ITS_EQUIP_TYPE_MAX
    }
    /// <summary>
    /// 串口号
    /// </summary>
    public enum PU_ITS_SERIAL_PORT_E
    {
        SERIAL_PORT_485_1 = 0,    //485-1
        SERIAL_PORT_232_1,        //485-2
        SERIAL_PORT_485_2,        //232-1
        SERIAL_PORT_485_3,        //485-3
        ITS_SERIAL_PORT_MAX = 255    //串口无
    }
    /// <summary>
    /// 雷达信息的发送方式
    /// </summary>
    public enum PU_ITS_RADAR_MSG_SENDTYPE_E
    {
        ITS_RADAR_MSG_SEND_SINGLE,      //单次发送(有车经过将上报消息)
        ITS_RADAR_MSG_SEND_CONTINOUS,   //连续发送(无论是否有车，都上报消息)
        ITS_RADAR_MSG_SEND_MANUAL,      //手工查询模式(查询一次，给一次消息)
        ITS_RADAR_MSG_SENDTYPE_MAX
    }
    /// <summary>
    /// 雷达类型
    /// </summary>
    public enum PU_ITS_RADAR_WORK_TYPE_E
    {
        ITS_RADAR_TYPE_SINGLE_DIR_DETECT, //单向探测
        ITS_RADAR_TYPE_DOUBLE_DIR_DETECT, //双向探测
        ITS_RADAR_TYPE_MAX
    }
    /// <summary>
    /// 雷达监测方向
    /// </summary>
    public enum PU_ITS_DETECT_DIR_E
    {
        ITS_DETECT_DIR_UNKNOWN = 0,
        ITS_DETECT_DIR_COMING,  //来向
        ITS_DETECT_DIR_GOING,   //去向
        ITS_DETECT_DIR_BOTH,    //双向
    }
    /// <summary>
    /// 雷达触发模式
    /// </summary>
    public enum PU_ITS_RADAR_TRIG_MODE_E
    {
        ITS_TRIG_MODE_UNKNOWN = 0,
        ITS_TRIG_MODE_COMING = 1,        //来向(车头)触
        ITS_TRIG_MODE_GOING = 2,     //去向(车尾)触发
        ITS_TRIG_MODE_BOTH = 3,     //双向触发
        ITS_TRIG_MODE_CONTINUUM = 4,     //持续触发
        ITS_TRIG_MODE_MAX
    }
    /// <summary>
    /// 线圈抓拍方案
    /// </summary>
    public enum PU_ITS_COIL_SNAP_TYPE_E
    {
        ITS_COIL_SNAP_SINGLE_NONE = 0,               //不抓拍
        ITS_COIL_SNAP_SINGLE_IN1,                    //单_入1抓拍
        ITS_COIL_SNAP_SINGLE_OUT1,                   //单_出1抓拍
        ITS_COIL_SNAP_DOUBLE_HEAD_IN2 = 21,          //双_车头_入2抓拍
        ITS_COIL_SNAP_DOUBLE_TAIL_OUT1_IN2,          //双_车尾_出1入2抓拍
        ITS_COIL_SNAP_DOUBLE_TAIL_OUT2,              //双_车尾_出2抓拍
        ITS_COIL_SNAP_TRIPLE_HEAD_IN3,               //三_车头_入3抓拍
        ITS_COIL_SNAP_TRIPLE_TAIL_OUT2_IN3,          //三_车尾_出2入3抓拍
        ITS_COIL_SNAP_TRIPLE_TAIL_OUT3,              //三_车尾_出3抓拍
        ITS_COIL_SNAP_DOUBLE_OUT1_OUT2_OUT2DELAY = 41,    //双_出1_出2_出2延时抓拍
        ITS_COIL_SNAP_DOUBLE_IN1_OUT2_OUT2DELAY,     //双_入1_出2_出2延时抓拍
        ITS_COIL_SNAP_DOUBLE_IN2_OUT2_OUT2DELAY,     //双_入2_出2_出2延时抓拍
        ITS_COIL_SNAP_TRIPLE_OUT1_OUT2_OUT3,         //三_出1_出2_出3抓拍
        ITS_COIL_SNAP_TRIPLE_OUT1_OUT2_OUT3DELAY,    //三_出1_出2_出3延时抓拍
        ITS_COIL_SNAP_TYPE_MAX
    }
    /// <summary>
    /// 违停球场景描述
    /// </summary>
    public enum PU_IBALL_SCENE_DIRECTION_TYPE_E
    {
        IBALL_SCENE_DIRECTION_SINGLE = 0,
        IBALL_SCENE_DIRECTION_DOUBLE,
        IBALL_SCENE_DIRECTION_MAX,
    }
    /// <summary>
    /// 车牌抓拍算法类型
    /// </summary>
    public enum PU_VLPR_ALG_MODE_E
    {
        VLPR_ALG_CHINESE,      // 中国车牌
        VLPR_ALG_EURO,         // 欧洲车牌
        VLPR_ALG_INA,          // 印尼车牌
        VLPR_ALG_MAX,
    }
    /// <summary>
    /// 接口类型
    /// </summary>
    public enum PU_REQ_TYPE_E
    {
        REQ_NULL,
        REQ_GET,
        REQ_SET
    }
    /// <summary>
    /// 接口业务类型
    /// </summary>
    public enum PU_INTERFACE_TYPE_E
    {
        PU_ITF_TYPE_SIM_PHONE_NUM = 1,
        PU_ITF_TYPE_MAX
    }
    /// <summary>
    /// 白平衡模式
    /// </summary>
    public enum PU_CAM_WB_MODE_E
    {
        PU_WB_MODE_AUTO = 0,              //自动    (环境比较稳定，色彩鲜艳)
        PU_WB_MODE_ATW,                      //自动跟踪  (白平衡差距大的地方)
        PU_WB_MODE_INDOOR,                   //室内
        PU_WB_MODE_OUTDOOR,                  //室外
        PU_WB_MODE_ONEPUSH_TRIGGER,          //一键触发
        PU_WB_MODE_MANUAL,                   //手动
        PU_WB_MODE_OUTDOOR_AUTO,             //室外自动
        PU_WB_MODE_SODIUM_VAPOR_LAMP_AUTO,   //钠灯自动
        PU_WB_MODE_SODIUM_VAPOR_LAMP,        //钠灯固定
        PU_WB_MODE_MERCURE_VAPOR_LAMP,       //汞水银灯
        PU_WB_MODE_FLUO_4200k,               // 4200k
        PU_WB_MODE_FLUORESCENTLAMP1,         //日光灯1 （2500~3500k）
        PU_WB_MODE_FLUORESCENTLAMP2,         //日光灯2 （3500~4500k）
        PU_WB_MODE_INCANDESCENTLAMP,         //白炽灯 2700~2900K
        PU_WB_MODE_SUNLIGHT,                 //太阳光
        PU_WB_MODE_MAX,
    }
    /// <summary>
    /// 宽动态模式
    /// </summary>
    public enum PU_VIDEO_WD_MODE_E
    {
        PU_WD_MODE_AUTO_WDR = 0,            //正常宽动态
        PU_WD_MODE_AUTO_ADWDR,              //修正暗色部分，宽动态增加了10db
        PU_WD_MODE_AUTO_CNT,                //宽动态由一副图像构成，图像处理
        PU_WD_MODE_AUTO_WDR_CNT,            //通过对比偏移来增加宽动态阶数
        PU_WD_MODE_AUTO_ADWDR_CNT,          //在对比偏移的基础上再增加10db
        PU_WD_MODE_RATIOFIX,                //短曝光快门速度固定，设置比例来确定长曝光
        PU_WD_MODE_HISTOGRAM,               //利用直方图来纠正过亮和过暗
        PU_WD_MODE_OFF_MODE,                //TI芯片专用，关闭
        PU_WD_MODE_FRAMESWITCH,             //TI芯片专用，帧切换
        PU_WD_MODE_STATIC_CHECK,            //TI芯片专用，静态模式
        PU_WD_MODE_DYNAMIC_CHECK,           //TI芯片专用，动态模式
        PU_WD_MODE_MAX
    }
    /// <summary>
    /// 日夜模式
    /// </summary>
    public enum PU_IRC_MODE_E
    {
        PU_IRC_MODE_COLOR = 0,           //彩色模式
        PU_IRC_MODE_GRAY,                //黑白模式
        PU_IRC_MODE_AUTO,                //自动模式
        PU_IRC_MODE_MAX
    }
    /// <summary>
    /// 日夜模式触发方式
    /// </summary>
    public enum PU_IRC_TRIGGER_MODE_E
    {
        PU_IRC_CAM_TRIGGER = 0,       //机芯触发
        PU_IRC_LUM_TRIGGER,           //光敏触发,默认光敏触发
        PU_IRC_SWITCH_TRIGGER,        //外部告警开关触发
        PU_IRC_TRIGGER_MAX
    }
    /// <summary>
    /// 增益类型
    /// </summary>
    public enum PU_GAIN_TYPE_E
    {
        PU_GAIN_TYPE_AUTO = 0,           //自动增益
        PU_GAIN_TYPE_DIGITAL,            //数字增益
        PU_GAIN_TYPE_ANALOG,             //模拟信号
        PU_GAIN_TYPE_MAX
    }
    /// <summary>
    /// 光圈参数
    /// </summary>
    public enum PU_IRIS_VALUE_E
    {
        IRIS_VALUE_1_2 = 0,
        IRIS_VALUE_1_4,
        IRIS_VALUE_1_6,              //光圈值为F1.6
        IRIS_VALUE_2_0,              //光圈值为F2.0 依次类推
        IRIS_VALUE_2_3,
        IRIS_VALUE_2_4,
        IRIS_VALUE_2_8,
        IRIS_VALUE_3_2,
        IRIS_VALUE_3_4,
        IRIS_VALUE_4_0,
        IRIS_VALUE_4_5,
        IRIS_VALUE_4_8,
        IRIS_VALUE_5_6,
        IRIS_VALUE_6_4,
        IRIS_VALUE_6_8,
        IRIS_VALUE_8_0,
        IRIS_VALUE_9_1,
        IRIS_VALUE_9_6,
        IRIS_VALUE_11_0,
        IRIS_VALUE_14_0,
        IRIS_VALUE_16_0,
        IRIS_VALUE_22_0,
        IRIS_VALUE_32_0,
        IRIS_VALUE_CLOSE,           //光圈关闭
        IRIS_VALUE_MAX
    }
    /// <summary>
    /// AES密钥类型
    /// </summary>
    public enum PU_AES_KEY_MODULE_E
    {
        PU_AES_KEY_MODULE_WEB = 0,
        PU_AES_KEY_MODULE_ONVIF,
        PU_AES_KEY_MODULE_T28181,
        PU_AES_KEY_MODULE_CA_PWD,
        PU_AES_KEY_MODULE_8021X,
        PU_AES_KEY_MODULE_SNMP,
        PU_AES_KEY_MODULE_DDNS,
        PU_AES_KEY_MODULE_SDK,
        PU_AES_KEY_MODULE_FACE_REC_DATABASE = 15,
        PU_AES_KEY_MODULE_MAX
    }
    /// <summary>
    /// 人脸库导入包类型
    /// </summary>
    public enum PU_FACE_PACKET_TYPE_E
    {
        FACE_PACKET_TYPE_PICMODE = 0, // 图片 + 人员信息
        FACE_PACKET_TYPE_FEATUREMODE, // 仅特征只支持SDK,需配合平台使用
        FACE_PACKET_TYPE_ALLPACKET, // 整包模式 图片 + 人员信息 + 人脸特征值
        FACE_PACKET_TYPE_MAX
    }
    /// <summary>
    /// 第二层元数据TYPE
    /// </summary>
    public enum LAYER_TWO_TYPE_E
    {
        COMMON = 0x00000001, // 通用   
        TARGET = 0x00000002, // 目标(车、人、人脸等)   
        RULE = 0x00000003,  // 规则(设定的规则框)   
        TALARM = 0x00000004, // 智能报警   
        TRECORD = 0x00000005  // 智能触发录像
    }
    /// <summary>
    /// 第三层元数据TYPE
    /// </summary>
    public enum LAYER_THREE_TYPE_E
    {
        PTS = 0x09000001, // 时间戳
        ITGT_TYPE = 0x07000011, // 智能类型
        IMG_WIDTH = 0x07000100, // 处理图片宽
        IMG_HEIGHT = 0x07000101, // 处理图片高

        FACE_SCORE = 0x04000013, // 人脸置信度
        FACE_ANGLE = 0x04000014, // 人脸角度
        FACE_ID = 0x07000016, // 人脸ID
        FACE_PANOPIC_SIZE = 0x07000018, // 人脸全景图片大小
        FACE_FACEPIC_SIZE = 0x07000019, // 人脸抠图图片大小
        FACE_PIC_TIME = 0x08000015, // 人脸抠图产生时间
        FACE_PIC_TZONE = 0x08000020, // 人脸抠图设备时区(单位ms 东区为+ 西区为-)
        HUMAN_FEATURE = 0x10000002, // 人体属性
        FACE_FEATURE = 0x11000003, // 人脸属性
        PANORAMA_PIC = 0x0A00000A, // 全景图片
        FACE_PIC = 0x0A000012, // 人脸抠图
        FACE_PIC_KPS = 0x07000012, // 人脸抠图kps质量过滤标志位
        HUMAN_PIC = 0x0A000013, // 人体抠图
        HUMAN_PIC_KPS = 0x07000013, // 人体抠图kps质量过滤标志位
        HUMAN_PIC_ROI = 0x0B000017, // 人体抠图中的人体目标框
        FACE_PANORAMA = 0x0A000017, // 人脸全景
        FACE_PIC_POSITION = 0x0B000011, // 人脸抠图小框位置
        FACE_POS = 0x0B000012, // 人脸位置(实时位置框)
        HUMAN_RECT = 0x0B000013, // 人体位置(实时位置框)
        HUMAN_RECT_POSITION = 0x0B000014, // 人体抠图小框位置

        FACE_MATCH = 0x0A000014, // 人脸数据库中匹配图片
        FACELIB_RECORDID = 0x07000017, // 名单库中的人脸ID，用来维持特征 record的一致性
        FACE_MATCHRATE = 0x07000020, // 人脸匹配率
        FACE_INFO = 0x12000001, // 人脸信息,对应数据库中信息
        FACE_LIB_TYPE = 0x07000022, // 名单库类型
        FACE_LIB_NAME = 0x0A000015, // 名单库名字
        TARGET_TYPE = 0x07000023, // target类型，当前用于区分人脸后处理抠图和人脸识别以及人脸识别多机协同
        FACE_LIB_ID = 0x07000024, // 名单库ID
        MMC_FACE_COMPARE_NUM_MAX = 0x07000025, //多机协同算法参数- 人脸比对数据
        MMC_FACE_WARNING_RECALL_RATE_MAX = 0x07000026, //多机协同算法参数- 人脸上报告警的召回率
        MMC_FACE_WARNING_RECALL_RATE_MIN = 0x07000027, //多机协同算法参数- 人脸预警率的下限值

        OBJ_ID = 0x07000021, // 目标ID
        OBJ_STATUS = 0x06000022, // 目标状态
        OBJ_POS = 0x0B000023, // 目标位置
        OBJ_TYPE = 0x06000024, // 目标类型
        OBJ_SPEED = 0x0C000025, // 目标速度
        OBJ_UPHALF_COLOR = 0x0F000026, // 目标上半部颜色
        OBJ_DOWNHALF_COLOR = 0x0F000027, // 目标下半部颜色
        RULE_TYPE = 0x07000031, // 规则类型
        RULE_LINE_POS = 0x0D000032, // 规则线位置
        RULE_LINE_DIR = 0x07000033, // 规则线方向
        RULE_AREA_POS = 0x0E000034, // 规则框位置
        OBJ_POS_R = 0x0B000035, // 目标位置(相对位置)
        OBJ_SPEED_R = 0x0C000036, // 目标速度(相对位置)
        RULE_LINE_POS_R = 0x0D000037, // 规则线位置(相对位置)
        RULE_AREA_POS_R = 0x0E000038, // 规则框位置(相对位置)

        LANE_ID = 0x07000002, // 车道号
        VEHICLE_TYPE = 0x07000003, // 车辆类型
        VEHICLE_TYPE_EXT = 0x07000406, //C50车辆类型
        VEHICLE_COLOR = 0x07000004, // 车辆颜色
        VEHICLE_DIRECTION = 0x07000005, // 车辆行驶方向
        VEHICLE_POS = 0x0B000005, // 车辆位置
        PLATE_TYPE = 0x07000006, // 车牌类型
        PLATE_POS = 0x0B000007, // 车牌位置
        PLATE_CHAR = 0x0A000008, // 车牌字符
        PLATE_PIC = 0x0A000009, // 车牌抠图
        PLATE_CONFIDENCE = 0x07000061, // 车牌置信度
        PLATE_COLOR = 0x07000062, // 车牌颜色
        PLATE_CHAR_POS = 0x0B000063, // 车牌字符位置
        PLATE_FACE_POS = 0x0B000064, // 车脸位置
        PLATE_MOVE_DIR = 0x07000065, // 车牌运动方向
        PLATE_SNAPSHOT_TYPE = 0x07000066, // 车牌抓拍类型
        VEHICLE_PIC = 0x0A000067, // 车辆特写图
        PIC_SNAPSHOT_TIMEMS = 0x09000003, // 抓拍时间(单位ms)
        PIC_SNAPSHOT_TIME = 0x07000068, // 抓拍时间
        PIC_SNAPSHOT_TZONE = 0x08000069, // 设备时区(单位ms 东区为+ 西区为-)
        DEVICE_ID = 0x0A000025,    //设备编号
        ROID_ID = 0x0A000026,    //道路编号
        DIR_ID = 0x0A000027,    //方向编号
        DIR_INFO = 0x0A000028,    //方向信息
        PANORAMA_PIC_SIZE = 0x07000073,  //全景图大小
        PLATE_PIC_SIZE = 0x07000074,    //车牌图大小
        VLPR_ALG_TYPE = 0x07000079, // 车牌算法类型
        REGULATION_CODE = 0x0A000029,//违章代码字符串

        ITS_TYPE = 0x04000032, // ITS 应用模式
        VEHICLE_TL_X = 0x0400002A, // 车辆位置左上角X坐标
        VEHICLE_TL_Y = 0x0400002B, // 车辆位置左上角Y坐标
        VEHICLE_BR_X = 0x0400002C, // 车辆位置右下角X坐标
        VEHICLE_BR_Y = 0x0400002D, // 车辆位置右下角Y坐标
        PLATE_TL_X = 0x0400002E, // 车牌位置左上角X坐标
        PLATE_TL_Y = 0x0400002F, // 车牌位置左上角Y坐标
        PLATE_BR_X = 0x04000030, // 车牌位置右下角X坐标
        PLATE_BR_Y = 0x04000031, // 车牌位置右下角Y坐标

        MICRO_PORT_TRAFFIC_STATISTICS = 0x070000A0,//车流量统计参数
        MICRO_PORT_TRAFFIC_STATISTICS_LANE_COUNT = 0x070000A1,//微卡口车流量统计车道数量
        MICRO_PORT_TRAFFIC_STATISTICS_LANE_INDEX = 0x070000A2,//微卡口车流量统计当前车道
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_COUNT = 0x070000A3,//车辆计数
        MICRO_PORT_TRAFFIC_STATISTICS_AVG_SPEED = 0x070000A4,//平均速度
        MICRO_PORT_TRAFFIC_STATISTICS_LANE_TIME_USED_RATIO = 0x070000A5,//车道时间占有率
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_DENSITY = 0x070000A6,//车流密度
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_HEAD_INTERVAL = 0x070000A7,//车头时间间隔
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_HEAD_SPACE_INTERVAL = 0x070000A8,//车头间隔
        MICRO_PORT_TRAFFIC_STATISTICS_CONGESTION_DEGREE = 0x070000A9,//交通状态
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_TYPE1_COUNT = 0x070000AA,//大型车数量
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_TYPE2_COUNT = 0x070000AB,//中型车数量
        MICRO_PORT_TRAFFIC_STATISTICS_VEHICLE_TYPE3_COUNT = 0x070000AC,//小型车数量
        MICRO_PORT_TRAFFIC_STATISTICS_QUEUE_LENGTH = 0x070000AD,//排队长度
        MICRO_PORT_TRAFFIC_STATISTICS_LANE_SPACE_USED_RATIO = 0x070000AE,//车道空间占有率
        ITS_TRAFFIC_LEFT_VEHICLE_COUNT = 0x070000AF, //its左转车数量
        ITS_TRAFFIC_STRAIGHT_VHEICLE_COUNT = 0x070000B0, //its直行车数量
        ITS_TRAFFIC_RIGHT_VHEICLE_COUNT = 0x070000B1, //its右转车数量
        ITS_TRAFFIC_TIME_ZONE = 0x070000B2, //its车流量统计时区
        ITS_TRAFFIC_SNAP_TIME = 0x070000B3, //its车流量统计抓拍时间

        VEHICLE_SPEED = 0x07000075,   //车辆速度
        REGULATION_TYPE = 0x07000076,   //违章类型
        ITS_FLOWRATE_FEATURE = 0x07000077, //its流量统计属性
        VEHICLE_MFR_TYPE = 0x07000078,   //机动车二次特征
        ITS_VEHICLE_FLOWRATE_FEATURE = 0x0700009A, //its车流量统计属性

        MFR_MAIN_CALL = 0x06000025,  //主驾驶打电话
        MFR_MAIN_BELT = 0x06000026,  //主驾驶安全带
        MFR_VICE_EXIST = 0x06000027,  //是否有副驾驶
        MFR_VICE_BELT = 0x06000035,  //副驾驶安全带
        MFR_YEAR_LOG = 0x06000036,  //年检标
        MFR_MAIN_SUN_VISOR = 0x06000030,  //主驾驶遮阳板
        MFR_VICE_SUN_VISOR = 0x06000031,  //副驾驶遮阳板
        MFR_NAP_KIN_BOX = 0x06000032,  //纸巾盒
        MFR_CAR_PENDANT = 0x06000034,  //挂件

        ITS_TRAFFIC_STATE = 0x07000079,  //车道交通状态
        CARDETECTION_POS = 0x0B000015, //停车位置
        HUMANCOUNT_NUM = 0x0B000016, //过线人数

        VEHICLE_BODY_RECT = 0x0B000008, // 车身位置
        NOMOTOR_BODY_RECT = 0x0B000009, // 非机动车车身位置
        MOTOR_COLOR = 0X07000600, //非机动车颜色 {黑(1)，蓝(2)，绿(3)，白/灰(4)，黄/橙/棕(5)，红/粉/紫(6)}   
        MOTOR_SUNSHADE = 0X07000601, //是否有遮阳伞{否(1),是(2)}
        MOTOR_SUNSHADE_COLOR = 0X07000602, //遮阳伞颜色 {黑(1)，蓝(2)，绿(3)，白/灰(4)，黄/橙/棕(5)，红/粉/紫(6)}
        MOTOR_MOTOR_CARRY = 0X07000603, //是否有携带物 {否(1),是(2)} 
        MOTOR_LICENSE_PLATE = 0X07000604, //是否有车牌{否(1),是(2)}

        CAR_PRE_BRAND = 0x0A000007, // 品牌字符 （大  众）
        CAR_SUB_BRAND = 0x0A000022, // 子款字符 （桑塔纳）
        CAR_TYPE_BRAND = 0x0A000023, // 车型字符 （轿  车）
        CAR_YEAR_BRAND = 0x0A000024, // 年款字符 （2011）
        VHD_OBJ_ID = 0x09000006, //机非人ID
        CAR_PRE_BRAND_INDEX = 0x06000028, // 品牌字符索引 （大  众）
        CAR_SUB_BRAND_INDEX = 0x06000029, // 子款字符索引 （桑塔纳）

        DEV_CNT = 0x03000070, // 设备数
        CHAN_ID = 0x03000071, // 通道号

        SHOULDER_RECT = 0x0B000018, // 头肩位置(排队长度)
        SHOULDER_NUM = 0x06000001, // 头肩个数（排队长度）
        QUEUE_TIME = 0x06000002, // 排队时长

        PEOPLE_NUM = 0X07000087, //人群密度检测算法人数
        HEADSHOULDER_POS = 0X0B000088, //人群密度检测算法返回框的地址
        AREARATIO = 0X07000089, //人群密度检测算法人群密度
        TRACK_OBJECT = 0x07000028, //跟踪目标id
        SEX = 0X0700008A, //性别
        AGE = 0X0700008B, //年龄
        META_GLASSES = 0X0700008C, //眼镜
        MOUTHMASK = 0X0700008D, //口罩
        UMBRELLA = 0X0700008E, //雨伞
        BACKPACK = 0X0700008F, //背包
        SHAPE = 0X07000090, //体型
        HAIR = 0X07000091, //发型
        SATCHEL = 0X07000092, //挎包
        LUGGAGE = 0X07000093, //行李
        CARRY = 0X07000094, //手拎物
        MOVEDIRECT = 0X07000095, //行进方向
        UPPERSTYLE = 0X07000096, //上衣款色
        UPPERCOLOR = 0X07000097, //上衣颜色
        LOWERSTYLE = 0X07000098, //下衣款色
        LOWERCOLOR = 0X07000099, //下衣颜色
        CHANNEL_ID = 0x09000078  //相机通道号
    }
    /// <summary>
    /// 交通球机抓拍图片类型
    /// </summary>
    public enum PU_IBALL_FRAME_TYPE_E
    {
        PU_IBALL_FRAME_TYPE_FAR = 0,   //远景图
        PU_IBALL_FRAME_TYPE_NEAR,    //近景图
        PU_IBALL_FRAME_TYPE_FEATURE, //特征图
        PU_IBALL_FRAME_TYPE_MAX
    }
    /// <summary>
    /// 交通球机循环模式
    /// </summary>
    public enum PU_CYCLIC_MODE_E
    {
        PU_E_NOT_CYCLIC = 0,  // 不循环
        PU_E_WEEK_CYCLIC,     // 周循环
    }
    /// <summary>
    /// 交通球机巡航模式
    /// </summary>
    public enum PU_TOUR_MODE_E
    {
        PU_E_DETECT_PRIORITY = 0, // 检测优先
        PU_E_SCENE_PRIORITY,      // 场景优先
    }
    /// <summary>
    /// 交通球机场景方向
    /// </summary>
    public enum PU_TD_SCENE_DIRECTION_E
    {
        PU_TD_SCENE_DIRECTION_SINGLE = 0,   //单向
        PU_TD_SCENE_DIRECTION_DOUBLE,       //双向
        PU_TD_SCENE_DIRECTION_MAX
    }
    /// <summary>
    /// 交通球机违法停车类型
    /// </summary>
    public enum PU_TD_ILLEGAL_TYPE_E
    {
        TDOME_ILLEGAL_TYPE_A = 0, //机动车违反规定停放
        TDOME_ILLEGAL_TYPE_B,     //机动车违反禁停标志
        TDOME_ILLEGAL_TYPE_C,     //非紧急情况高速应急车道或行车道停车
        TDOME_ILLEGAL_TYPE_D,     //未使用
        TDOME_ILLEGAL_TYPE_MAX
    }
    /// <summary>
    /// 一机多用
    /// </summary>
    public enum PU_ITGE_MODE_E
    {
        COMMON_MODE = 0,   //普通摄像机模式/多机互助纯实况模式        FACE_DETECTION_MODE,       //多算法款型/多机互助人卡模式        FACE_RECOGNITION_MODE,     //人脸识别模式        BAYONET_MODE,         //微卡口模式        MOTOR_DETECTION_MODE,       //多算法款型/多机互助微卡模式        ITS_MODE,       //ITS模式        VHD_FACE_MODE,      //多算法款型混行模式(人卡模式+微卡模式)        BA_MODE             //多算法款型行为分析模式
        CLOSE_ALG_MODE = 8,  //一拖N，全去使能模式
        ITS_EPOLICE_SINGLE_PIPE = 9,  //ITS电警单路流模式
        ITS_EPOLICE_DOUBLE_PIPE = 10, //ITS电警双路流模式
        ITS_TGATEWAY_SINGLE_PIPE = 11, //ITS卡口单路流模式
        ITS_TGATEWAY_DOUBLE_PIPE = 12, //ITS卡口双路流模式
        ITS_PEDRUNRED_MODE = 13, //ITS行人闯红灯模式
        ITGT_MODE_MAX,
    }
    /// <summary>
    /// 尾号限行索引方式
    /// </summary>
    public enum PU_ITS_RESTRICTED_INDEX_TYPE_E
    {
        RESTRICTE_INDEX_BY_WEEK, // 按星期索引
        RESTRICTE_INDEX_BY_DATE, // 按日期索引
        RESTRICTE_INDEX_MAX
    }
    /// <summary>
    /// 抓拍模式
    /// </summary>
    public enum FACE_DT_CAP_MODE_E
    {
        FACE_CAP_DEFAULT_MODE = 0, //默认抓拍模式,目标离开后抓拍
        FACE_CAP_QUICK_MODE,      //快速抓拍模式
        FACE_CAP_TIMED_MODE,      //定时抓拍模式(仅-E和-Q款型支持)
        FACE_CAP_CROWD_MODE,      //高密模式
    }
    /// <summary>
    /// H265解码相关结构返回值
    /// </summary>
    public enum PU_H265D_RETURN_E : UInt32
    {
        // 成功返回
        PU_H265D_OK = 0,              // 函数调用成功
        PU_H265D_NEED_MORE_BITS = 1,              // 函数调用成功，但需要更多bit数才能输出一帧
        PU_H265D_FIND_NEW_PIC = 2,

        //警告返回码：
        PU_H265D_NAL_HEADER_WARNING = 0x00000004,       //NAL头解码告警
        PU_H265D_VPS_WARNING = 0x00000008,       //VPS解码告警
        PU_H265D_SPS_WARNING = 0x00000010,       //SPS解码告警
        PU_H265D_PPS_WARNING = 0x00000020,       //PPS解码告警
        PU_H265D_SLICEHEADER_WARNING = 0x00000040,       //SliceHeader解码告警
        PU_H265D_SLICEDATA_WARNING = 0x00000080,       //SliceData解码告警

        // 一般错误
        PU_H265D_INVALID_ARGUMENT = 0xF0401000,     //输入的形参不正确
        PU_H265D_DECODER_NOT_CREATE,                         //解码器未创建

        // 初始化错误
        PU_H265D_MALLOC_FAIL = 0xF0402000,     //内存分配失败
        PU_H265D_INVALID_MAX_WIDTH,                          //最大宽度超过范围
        PU_H265D_INVALID_MAX_HEIGHT,                         //最大高度超过范围
        PU_H265D_INVALID_MAX_REF_PIC,                        //最大参考帧数超过范围
        PU_H265D_INVALID_THREAD_CONTROL,                     //非法线程控制
        PU_H265D_INVALID_MALLOC_FXN,                         //Malloc回调函数指针无效
        PU_H265D_INVALID_FREE_FXN,                           //Free回调函数指针无效
        PU_H265D_INVALID_LOG_FXN,                            //Log回调函数指针无效
        PU_H265D_STREAMBUF_NULL,                             //解码器输入码流buf为空
        PU_H265D_INVALID_STREAMBUF_LENGTH,                   //解码器输入码流字节数错误
        PU_H265D_YUVBUF_NULL,                                //解码器输出YUV buffer指针为空
        PU_H265D_YUVBUF_ADDR_NOT_ALIGN_16,                   //解码器输出YUV buffer address未16字节对齐
        PU_H265D_POSTPROCESS_ERR,                            //后处理方法选择错误
        PU_H265D_ERRCONCEAL_ERR,                             //错误隐藏参数配置错误

        // 解码错误
        PU_H265D_NAL_HEADER_ERR = 0xF0404001,   //NAL头解码错误
        PU_H265D_VPS_ERR = 0xF0404002,   //VPS解码错误
        PU_H265D_SPS_ERR = 0xF0404003,   //SPS解码错误
        PU_H265D_PPS_ERR = 0xF0404004,   //PPS解码错误
        PU_H265D_SLICEHEADER_ERR = 0xF0404005,   //SliceHeader解码错误
        PU_H265D_SLICEDATA_ERR = 0xF0404006,   //SliceData解码错误

        //解码警告
        PU_H265D_FRAME_DECODE_WARN = 0xE0404007,   //帧数据错误，该码流可能有误码，YUV输出图像质量不做保证
        PU_H265D_THREAD_ERROR = 0xE0404008    //多线程错误 lcc

    }
    /// <summary>
    /// H265D线程类型
    /// </summary>
    public enum PU_H265D_THREADTYPE_E
    {
        PU_H265D_SINGLE_THREAD = 0,       //单线程
        PU_H265D_MULTI_THREAD                 //多线程
    }
    /// <summary>
    /// H265D输出序
    /// </summary>
    public enum PU_H265D_OUTPUTORDER_E
    {
        PU_H265D_DECODE_ORDER = 0,       //按解码序输出
        PU_H265D_DISPLAY_ORDER               //按显示序输出
    }
    /// <summary>
    /// LOG等级
    /// </summary>
    public enum PU_VIDEO_ALG_LOG_LEVEL
    {
        PU_VIDEO_ALG_LOG_ERROR = 0,   // 出错时的LOG信息
        PU_VIDEO_ALG_LOG_WARNING,     // 报警时的LOG信息
        PU_VIDEO_ALG_LOG_INFO,        // 打印的辅助信息
        PU_VIDEO_ALG_LOG_DEBUG        // 打印的调试信息，用于开发人员调试

    }
    /// <summary>
    /// H265解码模式
    /// </summary>
    public enum PU_H265D_DECODEMODE_E
    {
        PU_H265D_DECODE = 0,       //正常解码
        PU_H265D_DECODE_END        //解码完毕并要求解码器输出残留图像
    }
    /// <summary>
    /// H265帧类型
    /// </summary>
    public enum PU_H265D_FRAMETYPE_E
    {
        PU_H265D_FRAME_I = 0, //I帧
        PU_H265D_FRAME_P,     //P帧
        PU_H265D_FRAME_B,     //B帧
        PU_H265D_FRAME_UNKNOWN
    }
    /// <summary>
    /// H265解码类型
    /// </summary>
    public enum PU_H265D_DECODESTATUS_E
    {
        PU_H265_DEC_GETDISPLAY = 0, //已经解码出一帧并输出，可用于显示
        PU_H265_DEC_NEED_MORE_BITS, //解码器没有图像输出，需要更多的码流
        PU_H265_DEC_NO_PICTURE,     //解码完毕，已经输出全部图像
        PU_H265_DEC_ERR_HANDLE      //句柄错误
    }
    /// <summary>
    /// 主从关联角色参数
    /// </summary>
    public enum PU_MASTER_SLAVE_ROLE_E
    {
        PU_ROLE_NONE = 0, //用于删除主从关系
        PU_ROLE_MASTRE, //主从关联中的主机
        PU_ROLE_SLAVE, //主从关联中的从机
        PU_ROLE_MAX,
    }
    /// <summary>
    /// 主从跟踪策略
    /// </summary>
    public enum PU_MASTER_SLAVE_TRACK_MODE_E
    {
        PU_MODE_OBJ_DISAPPEAR = 0, //目标消失，跟踪直至目标离开枪机画面
        PU_MODE_TIME_FIXED // 固定时间，跟踪目标指定时间，到时间后切换目标
    }
    /// <summary>
    /// 跟踪目标占画面比例
    /// </summary>
    public enum PU_TRACK_OBJECT_SIZE_E
    {
        PU_OBJECT_SIZE_HALF = 0, //目标占画面二分之一
        PU_OBJECT_SIZE_ONE_THIRD, //目标占画面三分之一
        PU_OBJECT_SIZE_QUARTER, //目标占画面四分之一
        PU_OBJECT_SIZE_FIFTH, //目标占画面五分之一
    }
    /// <summary>
    /// 定位类型
    /// </summary>
    public enum PU_LOCATE_TYPE_E
    {
        PU_LOCATE_POINT, //点定位
        PU_LOCATE_RECT, //框定位
    }
    /// <summary>
    /// 画框方向
    /// </summary>
    public enum PU_DRAW_DIR_E
    {
        PU_DIR_TOP_LEFT_TO_RIGHT_BOTTOM, //从左上到右下画框
        PU_DIR_RIGHT_BOTTOM_TO_TOP_LEFT, //从右下到左上画框
    }
    /// <summary>
    /// 标定类型
    /// </summary>
    public enum PU_CALIBRATION_TYPE_E
    {
        PU_CALIBRATION_MANUAL = 0, //手动
        PU_CALIBRATION_AUTO, //自动
        PU_CALIBRATION_MAX
    }
    /// <summary>
    /// 主从标定状态
    /// </summary>
    public enum PU_CALIBRATION_STATUS_E
    {
        CALIBRATION_INIT = 0, //未进行标定
        CALIBRATION_COMPLETE, //标定已完成
        CALIBRATION_ING,      //标定进行中，星图定点使用
        CALIBRATION_MAX
    }
    /// <summary>
    /// 星图标定瞬间状态
    /// </summary>
    public enum PU_CALIBRATION_INSTANCE_STATUS_E
    {
        PU_CALIBRATION_SUCCESS = 0,                 //标定成功
        PU_CALIBRATION_FAIL,                        //标定失败
        PU_CALIBRATION_INSTANCE_MAX
    }
    /// <summary>
    /// 从设备onvif状态
    /// </summary>
    public enum PU_SLAVE_ONVIF_STATUS_TYPE_E
    {
        SLAVE_ONVIF_STATUS_NORMAL,        //正常
        SLAVE_ONVIF_STATUS_USER_ERROR,    //用户名密码错误
        SLAVE_ONVIF_STATUS_ABNORMAL,      //异常
        SLAVE_ONVIF_STATUS_FRAMERATE_INAPPROPRIATE,      //帧率不合适
        SLAVE_ONVIF_STATUS_RESOLUTION_INAPPROPRIATE,     //分辨率不合适
        SLAVE_ONVIF_STATUS_MEDIA_ENCODING_INAPPROPRIATE, //不符合MEDIA模式的编码模式
        SLAVE_ONVIF_STATUS_MEDIA2_ENCODING_INAPPROPRIATE,//不符合MEDIA2模式的编码模式
        SLAVE_ONVIF_STATUS_MAX
    }
    /// <summary>
    /// 从设备rtsp状态
    /// </summary>
    public enum PU_SLAVE_RTSP_STATUS_TYPE_E
    {
        SLAVE_RTSP_STATUS_NORMAL,        //正常
        SLAVE_RTSP_STATUS_URL_ERR,       //rtsp url异常
        SLAVE_RTSP_STATUS_USER_ERR,      //用户名密码错误
        SLAVE_RTSP_STATUS_ABNORMAL,      //其他异常
        SLAVE_RTSP_STATUS_MAX
    }
    /// <summary>
    /// 1拖N场景类型
    /// </summary>
    public enum PU_1TN_SUPPORT_MODE_E
    {
        TN_COMMON_SUPPORT_MODE = 0,      //不支持智能模式    
        TN_FACE_TWO_SUPPORT_MODE = 1,      //两路人脸模式    
        TN_VHD_TWO_SUPPORT_MODE = 2,      //两路机非人模式    
        TN_FACE_VHD_SUPPORT_MODE = 3,      //两路：一路人脸一路机非人    
        TN_FACE_THREE_SUPPORT_MODE = 4,      //三路人脸    
        TN_VHD_THREE_SUPPORT_MODE = 5,      //三路机非人模式    
        TN_FACE_VHD_TWO_SUPPORT_MODE = 6,      //三路：一路人脸二路机非人    
        TN_FACE_TWO_VHD_SUPPORT_MODE = 7,      //三路：两路人脸一路机非人    
        TN_FACE_FIVE_SUPPORT_MODE = 8,      //5路人脸+一路识别    
        TN_FACE_TWO_VHD_TWO_SUPPORT_MODE = 9,      //2机非人+2人脸模式    
        TN_VHD_FOUR_SUPPORT_MODE = 10,     //4机非人模式
        TN_VHDFACE_TWO_SUPPORT_MODE = 11,     //2路混型
        TN_VHDFACE_FACE_TWO_SUPPORT_MODE = 12,     //1路混型, 2路人脸
        TN_VHDFACE_VHD_TWO_SUPPORT_MODE = 13,     //1路混型，2路机非人
        TN_VHDFACE_VHD_FACE_SUPPORT_MODE = 14,     //1路混型，1路人脸，1路机非人
        TN_ITGT_SUPPORT_MODE_MAX = 64
    }
    /// <summary>
    /// ONVIF版本信息值
    /// </summary>
    public enum PU_ONVIF_VERSION_ENUM_E
    {
        ONVIF_VERSION_2_6 = 0,
        ONVIF_VERSION_2_6_1,
        ONVIF_VERSION_MAX
    }
    /// <summary>
    /// 图像算法类型
    /// </summary>
    public enum PU_IPS_ALGORITHM_TYPE_E
    {
        ISP_ALG_TYPE_ADPAT = 0,            // 场景自适应算法
        ISP_ALG_TYPE_MAX_EX
    }
    /// <summary>
    /// 行进方向
    /// </summary>
    public enum META_MOVE_DIRECT_E
    {
        DIRECT_UNKNOWN = 0, //未知
        DIRECT_FORWARD,     //向前
        DIRECT_BACKWARD,    //向后
    }
    /// <summary>
    /// 行进速度
    /// </summary>
    public enum META_MOVE_SPEED_E
    {
        SPEED_UNKNOWN = 0, //未知
        SPEED_SLOW,        //慢
        SPEED_FAST,        //快
    }
    /// <summary>
    /// ISP场景参数类型
    /// </summary>
    public enum PU_SCENE_PARAM_TYPE_E
    {
        PU_SCENE_PARAM_COMM = 0,     //操作通用场景参数
        PU_SCENE_PARAM_SNAPSHOT = 1, //操作ITS抓拍/多算法并行设备混行模式下微卡场景参数	
        PU_SCENE_PARAM_HUMAN = 2,    //操作多算法并行设备人卡模式/行为分析模式场景参数	
        PU_SCENE_PARAM_VEHICLE = 3,  //操作多算法并行设备微卡模式场景参数
        PU_SCENE_PARAM_MAX
    }
    /// <summary>
    /// ISP详细参数类型
    /// </summary>
    public enum PU_ISP_PARTICULAR_PARA_TYPE_E
    {
        PU_ISP_HUMAN,            // 多算法并行设备单模式人卡、行为分析ISP参数
        PU_ISP_HUMAN_DEFAULT,    // 多算法并行设备单模式人卡、行为分析ISP默认参数，只支持获取
        PU_ISP_VEHICLE,          // 多算法并行设备单模式微卡ISP参数
        PU_ISP_VEHICLE_DEFAULT,   // 多算法并行设备单模式微卡ISP默认参数，只支持获取
        PU_ISP_NORMAL,            // 普通ISP 参数
        PU_ISP_DEFAULT       //默认ISP参数
    }
    /// <summary>
    /// 机非人对象类型
    /// </summary>
    public enum PU_ITGT_VHD_OBJ_TYPE_E
    {
        PU_OBJ_VEH,     //Vehicle
        PU_OBJ_PED,     //Pedestrian
        PU_OBJ_NMV      //Non-Motorized Vehicle
    }
    /// <summary>
    /// ITS图片合成类型
    /// </summary>
    public enum PU_ITS_PIC_SYNTHESIS_TYPE
    {
        ITS_TYPE_EPOLICE_PIC_SYNTHESIS = 0,       //电警
        ITS_TYPE_TGATEWAY_PIC_SYNTHESIS = 1,      //卡口
        ITS_TYPE_PASSAGEWAY_PIC_SYNTHESIS = 2,    //出入口
        ITS_TYPE_PEDRUNRED_PIC_SYNTHESIS = 3,     //行人闯红灯   
        ITS_TYPE_PIC_SYNTHESIS_MAX,
    }
    /// <summary>
    /// 人脸OSD叠加类型
    /// </summary>
    public enum PU_FACE_OSD_TYPE_E
    {
        FACE_TIME_OSD = 0,       //时间叠加
        FACE_DEV_ID_OSD,         //设备编号
        FACE_MONITOR_INFO_OSD,  //监测点信息
        FACE_OSD_TYPE_MAX
    }
    /// <summary>
    /// 热度图查询类型
    /// </summary>
    public enum PU_HOTMAP_TYPE_E
    {
        TYPE_HOTMAP_SPACE,    //空间维度热度图
        TYPE_HOTMAP_TIME      //时间维度热度图
    }
    /// <summary>
    /// 人脸抠图大小类型
    /// </summary>
    public enum PU_FACE_SYN_SCALE_TYPE_E
    {
        FACE_SYN_SCALE_LAYER1 = 0,      //小
        FACE_SYN_SCALE_LAYER2 = 1,      //中
        FACE_SYN_SCALE_LAYER3 = 2,      //大
        FACE_SYN_SCALE_MAX,
    }
    /// <summary>
    /// 补光灯手、自动模式控制
    /// </summary>
    public enum PU_LAMP_CTRL_MODE_E
    {
        LAMP_CTRL_MODE_AUTO = 0,                   //自动
        LAMP_CTRL_MODE_MANUAL,                     //手动
    }
    /// <summary>
    /// 人脸库状态
    /// </summary>
    public enum PU_FEATURE_STATUS_TYPE_E
    {
        FEATURE_STATUS_UNKNOWN = 0,         // 新建人脸库状态
        FEATURE_STATUS_QUERY_ALL,           // 查询全部
        FEATURE_STATUS_REEXTRACT,           // 重新提取，用于人脸库状态，算法升级时触发
        FEATURE_STATUS_UNEXTRACT,           // 未提取
        FEATURE_STATUS_EXTRACTED,           // 已提取
        FEATURE_STATUS_FAILED,              // 提取失败，用于查询失败的人脸图片
        FEATURE_STATUS_ERRIMGSIZE,          // 图片尺寸不规范
        FEATURE_STATUS_DECODE_FAIL,         // 图片解码失败
        FEATURE_STATUS_DETECTION_FAIL,      // 人脸检测失败
        FEATURE_STATUS_EXTRACT_FAIL,        // 特征提取失败
        FEATURE_STATUS_ADD_FEATURE_FAIL,    // 特征写入失败
        FEATURE_STATUS_MAX,
    }
    /// <summary>
    /// 感兴趣区域测光类型(微卡口车牌测光/人脸检测人脸测光)
    /// </summary>
    public enum PU_ROIMETER_TYPE_E
    {
        ROIMETER_TYPE_FACE = 0,    //人脸曝光
        ROIMETER_TYPE_VEHICLE,     //车牌曝光
        ROIMETER_TYPE_INVALID,
    }
    /// <summary>
    /// P-IRIS光圈子类型
    /// </summary>
    public enum PU_CAM_P_IRIS_TYPE_E
    {
        CAM_P_IRIS_HV1250P = 0,       //Piris或hall光圈
        CAM_P_IRIS_HV03617P = 1,       //客户自选镜头类型
        CAM_P_IRIS_BUTT,
    }
    /// <summary>
    /// 通道状态
    /// </summary>
    public enum PU_CHANNEL_STATUS_E
    {
        CHANNEL_STATUS_ERR = 0,   //异常
        CHANNEL_STATUS_NORMAL,    //正常
        CHANNEL_STATUS_MAX
    }
    /// <summary>
    /// 触发类型枚举值
    /// </summary>
    public enum PU_CAMPUS_TRIG_TYPE_E
    {
        PU_CAMPUS_TRIG_MODE_GROUND = 0, // 地感线圈触发
        PU_CAMPUS_TRIG_MODE_DT_LINE,       // 视频拌线触发
        PU_CAMPUS_TRIG_MODE_HYBRID,        // 混合触发模式(线圈触发优先，拌线触发为辅)
        PU_CAMPUS_TRIG_MODE_MAX
    }
    /// <summary>
    /// 元数据请求分类
    /// </summary>
    public enum PU_METADATA_REQUEST_TYPE_E
    {
        PU_METADATA_REQUEST_COMMON = 0,    //不区分元数据类型
        PU_METADATA_REQUEST_REST = 1,      //只请求检测框信息
        PU_METADATA_REQUEST_OTHERS = 2,    //除去检测框信息的其他信息
        PU_METADATA_REQUEST_MAX,
    }
    /// <summary>
    /// 违章抓拍方式
    /// </summary>
    public enum PU_ITS_REGULA_SNAP_TYPE
    {
        PU_ITS_REGULA_SNAP_SINGLE_SHUTTER,         // 单快门
        PU_ITS_REGULA_SNAP_DOUBLE_SHUTTER,         // 双快门
        PU_ITS_REGULA_SNAP_TYPE_MAX
    }
    /// <summary>
    /// 补光灯控制类型
    /// </summary>
    public enum PU_CAPLAMPCTRL_TYPE_E
    {
        TYPE_CTRLTYPE_IO = 0,   //IO控制
        TYPE_CTRLTYPE_RS485 = 1,   //485控制
        TYPE_CTRLTYPE_PWM = 2,   //PWM控制
        TYPE_CTRLTYPE_MAX
    }
    /// <summary>
    /// 日志打印级别
    /// </summary>
    public enum PU_SDK_LOG_LEVEL_E
    {
        PU_LOG_LEVEL_NOTICE = 0,        //提示日志
        PU_LOG_LEVEL_DEBUG = 1,        //调试日志
        PU_LOG_LEVEL_WARNING = 2,        //告警日志
        PU_LOG_LEVEL_ERROR = 3,        //错误日志
        PU_LOG_LEVEL_OPERATION = 4,        //操作日志
        PU_LOG_LEVEL_RUNNING = 5,        //运行日志
        PU_LOG_LEVEL_CRITICAL = 6,        //致命日志
        PU_LOG_LEVEL_MAX
    }
    /// <summary>
    /// 调试日志模块
    /// </summary>
    public enum PU_DEBUG_MODEL_E
    {
        PU_DEBUG_MODEL_ALL = 0,  //所有模块
        PU_DEBUG_MODEL_CONTROL,  //主控模块
        PU_DEBUG_MODEL_COMM,     //COMM模块
        PU_DEBUG_MODEL_RTP,      //RTP模块
        PU_DEBUG_MODEL_CODEC,    //编码模块
        PU_DEBUG_MODEL_PTZ,      //云镜模块
        PU_DEBUG_MODEL_ALARM,    //告警模块
        PU_DEBUG_MODEL_WEB,      //web模块
        PU_DEBUG_MODEL_IQ_IMG,   //IO IMG模块
        PU_DEBUG_MODEL_ONVIF,    //ONVIF模块
        PU_DEBUG_MODEL_RECORD = 10, //录像模块
        PU_DEBUG_MODEL_RDA,      //RDA模块
        PU_DEBUG_MOEDL_SDK,      //SDK模块
        PU_DEBUG_MODEL_DECODER,  //解码模块
        PU_DEBUG_MODEL_DISCOVER, //设备发现模块
        PU_DEBUG_MODEL_UPDATE,   //升级模块
        PU_DEBUG_MODEL_DAEMON,   //守护模块
        PU_DEBUG_MODEL_DRIVER,   //驱动模块
        PU_DEBUG_MODEL_28181,    //28181模块
        PU_DEBUG_MODEL_NET,      //网络模块
        PU_DEBUG_MODEL_GENETEC = 20, //GENETEC模块
        PU_DEBUG_MODEL_ITGT,     //智能模块
        PU_DEBUG_MODEL_SEP,      //SEP模块
        PU_DEBUG_MODEL_RC,       //RtspClient模块
        PU_DEBUG_MODEL_RS,       //反向收流中心模块
        PU_DEBUG_MODEL_ITGT_ALG, //智能算法
        PU_DEBUG_MODEL_REST,     //HTTPREST模块
        PU_DEBUG_MODEL_ODS,      //Omni data Structuring，星图模块
        PU_DEBUG_MODEL_ITGT_PERF,  //智能性能调试信息模块
        PU_DEBUG_MODEL_ITGT_ALG_DET,  //智能控制算法目标检测框元数据的发送调试信息模块
        PU_DEBUG_MODEL_END
    }
    /// <summary>
    /// 传输协议类型
    /// </summary>
    public enum PU_TRANS_PROTOCOL_TYPE_E
    {
        HTTP_ONLY = 0,
        HTTPS_ONLY,
        HTTP_AND_HTTPS,
    }
    /// <summary>
    /// rest认证方式
    /// </summary>
    public enum PU_REST_AUTHORIZATION_TYPE_E
    {
        PU_REST_AUTHORIZATION_DIGEST_MD5,           //digest with algorithm MD5 
        PU_REST_AUTHORIZATION_DIGEST_SHA256,        //digest with algorithm SHA256
        PU_REST_AUTHORIZATION_DIGEST_MD5_AND_SHA256 //support MD5 and SHA256
    }
    /// <summary>
    /// 录像数据类型
    /// </summary>
    public enum PU_RECORD_DATA_TYPE_E
    {
        PU_RECORD_VIDEO = 0,  // 视频数据
        PU_RECORD_META,       // 元数据
        PU_RECORD_DATA_MAX
    }
    /// <summary>
    /// 跟踪抓拍模式
    /// </summary>
    public enum PU_TRACK_SNAP_TYPE_E//PU_TRACK_SNAP_TYPE_ ?
    {
        PU_TRACK_SNAP_COMMON = 0, //目标抓拍
        PU_TRACK_SNAP_BEH, //周界抓拍
    }
    /// <summary>
    /// 设备支持的查询的能力类型
    /// </summary>
    public enum PU_DATA_BASE_TYPE_E
    {
        PU_COMMON_DATA_BASE = 0,            //普通
        PU_FACE_DETECTION_DATA_BASE,        //人脸检测
        PU_BODY_DETECTION_DATA_BASE,        //人体
        PU_FACE_RECOGNITION_DATA_BASE,      //人脸识别
        PU_FACE_SUP_RECOGNITION_DATA_BASE,  //补充识别
        PU_BODY_FACE_DATA_BASE,             //人脸+人体
        PU_BODY_FACE_RECOGNITION_DATA_BASE, //人脸+人体+识别
        PU_VEH_DATA_BASE,                   //车辆
        PU_RIDER_DATA_BASE,                 //骑行人
        PU_DATA_BASE_MAX,
    }
    #endregion
    #region"结构体定义"
    /// <summary>
    /// 设备版本信息
    /// </summary>
    public struct PU_DEVICE_VERSION
    {
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szVerSoftware;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szVerUboot;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szVerKernel;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szVerHardware;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szReserved;
    }

    /// <summary>
    /// 设备信息
    /// </summary>
    public struct PU_DEVICEINFO_S
    {
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_DEVICE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szDeviceName;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_FAC_NAME_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szDeviceFac;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_DEVICE_TYPE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szDeviceType;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_SERIAL_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szSerialNumber;
        PU_DEVICE_VERSION stDeviceVersion;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szReserved;
    }


    /// <summary>
    /// 车道属性参数
    /// </summary>
    public struct PU_LANE_ATTR_PARA_S
    {
        public PU_ITS_ROAD_PURPOSE_E enLanePurpose;              //  车道类型/用途
        public PU_ITS_CAR_DRV_DIR_E enLaneDirection;            //  车道方向
    }
    /// <summary>
    /// 车道线配置
    /// </summary>
    public struct PU_IMRS_LINE_S
    {
        public PU_IGT_POINT_S stStartPoint;
        public PU_IGT_POINT_S stEndPoint;
    }
    /// <summary>
    /// 智能分析点坐标
    /// </summary>
    public struct PU_IGT_POINT_S
    {
        ushort usPointPosX;
        ushort usPointPosY;
    }

    public struct PU_VIM_POINT_ST
    {
        public int lPointPosX;
        public int lPointPosY;
    }
    /// <summary>
    /// 位置信息
    /// </summary>
    public struct LOCATION_INFO_S
    {
        public float fxDegree;       //球机角度
        public float fyDegree;
        public float fDZoomRatio;
        public int lPOS;          //POS
        public VIDEO_VENC_ROTATION_E enVideoRotation; //视频镜像模式
    }

    public struct PU_AREA_S
    {
        public UInt32 ulIndex;
        public PU_ENABLE_TYPE_E enEnable;
        public UInt32 uPointNum;              /* 区域多边形顶点数目 */
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AREA_POINTS_NUM, ArraySubType = UnmanagedType.I1)]
        public PU_VIM_POINT_ST[] stPoint;   /*点坐标*/
        public LOCATION_INFO_S stLocation;                     //云台位置信息  
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = IGT_AREA_NAME_LEN, ArraySubType = UnmanagedType.I1)]
        byte[] stAreaName;  //区域名称
    }


    public struct AERADTC_LIST_S
    {
        public UInt32 ulAreaNum;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AREA_NUM, ArraySubType = UnmanagedType.I1)]
        public PU_AREA_S[] stArea;
    }
    /// <summary>
    /// 车牌参数
    /// </summary>
    public struct PU_VLP_PARA_S
    {
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLATE_LOCAL_ZH_LEN, ArraySubType = UnmanagedType.I1)]
        byte[] szPlateLocalZH;
        bool bInclineRectify;
        int iPlateSize;
    }

    public struct PU_VLPR_PARA_V3_S
    {
        public UInt32 ulChnID;
        public bool bEnable;
        public int iLaneNum;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_AREA_VERTEX)]
        public PU_IMRS_LINE_S[] stLane;
        public PU_VEHICLE_DIR_E enVehicleDir;
        public PU_VLPR_CATCH_MODE_E enCatchMode;
        public PU_VLP_PARA_S stVLPParam;
        public bool bVColorDetection;
        public bool bVTypeDetection;
        public bool bSendPanoramaPic;
        public bool bSendPlatePic;
        public PU_VLPR_ALG_MODE_E enAlgMode;
        public bool bExposureEnable;
        public UInt32 ulROIMeterLevel;
        public bool bVlprEnhancement;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LANE_NUM)]
        public PU_LANE_ATTR_PARA_S[] stLaneAttr;
        public AERADTC_LIST_S stAreaList;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_AREA_VERTEX)]
        public PU_IMRS_LINE_S[] stDetectLine;
        public bool bEnableVehicleMfrType; //是否启用二次特征
        public bool bEnableFacePic;        //是否启用人脸抠图
        public PU_CAMPUS_MODE_PARA_S stCampusModePara;
        public UInt32 ulPlateExposureTime;                    //车牌亮度持续补偿时间 
        public bool enEnhanceMeter;                        //车牌增强开关  设置为FALSE时代表ON、设置为TRUE时代表OFF
        public uint ulEnhanceLevel;                         //车牌增强强度 1~100
        //[MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_RESERVE_EX_LEN - (sizeof(bool) * 3) - sizeof(PU_CAMPUS_MODE_PARA_S) - sizeof(UInt32) - sizeof(uint))]
        public byte[] szReserved;
    }


    /// <summary>
    /// 告警上报信息
    /// </summary>
    public struct PU_ALARM_REPORT_S
    {
        public long ulDeviceId;
        public PU_ALARM_TYPE_E enAlarmType;
        public PU_TIME_S stTime;
        public PU_ALARM_ACTION_E enAction;
        public long ulAlarmId;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szReserve;
    }


    /// <summary>
    /// 园区出入口参数配置
    /// </summary>
    public struct PU_CAMPUS_MODE_PARA_S
    {
        public bool bEnable;                     // 园区出入口业务功能使能开关
        public PU_CAMPUS_TRIG_TYPE_E enTrigType; // 触发类型:0-线圈触发  1-视频拌线触发   2-混合模式触发
        public bool bEnableNoPlateVeh;    // 是否上报无牌车
        public bool bEnableDataAck;         // 启用数据回传
    }

    /// <summary>
    /// 布撤防结构体
    /// </summary>
    public struct PU_GUARD_PARA_S
    {
        public UInt32 ulDeviceId;
        public UInt32 ulState;
    }
    /// <summary>
    /// 布撤防状态
    /// </summary>
    public struct PU_GUARD_STATE_S
    {
        public PU_GUARD_PARA_S[] szChannelStateList; //PU_CAMERA_NUM_MAX
        public PU_GUARD_PARA_S[] szInputStateList;//PU_DIO_NUM_MAX
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_RESERVE_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] szReserve;
    }

    /// <summary>
    /// 矩形区域信息
    /// </summary>
    public struct PU_AREA_INFO_S
    {
        public UInt32 ulStartX;
        public UInt32 ulStartY;
        public UInt32 ulWidth;
        public UInt32 ulHeight;
    }


    /// <summary>
    /// 元数据矩形信息
    /// </summary>
    public struct META_RECT_S
    {
        public ushort usX;      // 矩形左上顶点的x坐标    
        public ushort usY;      // 矩形左上顶点的y坐标
        public ushort usWidth;  // 矩形宽
        public ushort usHeight; // 矩形高
    }
    /// <summary>
    /// 元数据点信息
    /// </summary>
    public struct META_POINT_S
    {
        public ushort usX; // x    
        public ushort usY; // y
    }
    /// <summary>
    /// 元数据线信息
    /// </summary>
    public struct META_LINE_S
    {
        public META_POINT_S stStartPoint; // 起始点
        public META_POINT_S stEndPoint;   // 终止点
    }
    /// <summary>
    /// 元数据多边形信息
    /// </summary>
    public struct META_POLYGON_S
    {
        public uint uPointNum;         // 点个数      
        public META_POINT_S[] astPts;
    }

    public struct META_COLOR_S
    {
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public int[] auc_r;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public int auc_g;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public int auc_b;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public int auc_ConfLev; // 置信度   
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public int auc_ColorID; // ID
    }



    /// <summary>
    /// 人体属性结果
    /// </summary>
    public struct META_HUMAN_ATTRIBUTES_S
    {
        public bool isVaild;

        //INT 定义的属性 0 代表 未知，1-n依次代表后面的属性具体含义
        public int age;                            //年龄 {少年,青年,老年} 
        public int gender;                         //性别{男，女}
        public int upperStyle;                     //上衣款式 {长袖，短袖} 
        public int upperColor;                     //上衣颜色 {黑，蓝，绿，白/灰，黄/橙/棕，红/粉/紫}  
        public int upperTexture;                   //上衣纹理 {纯色，条纹} 
        public int lowerStyle;                     //下衣款式 {长裤,短裤}      
        public int lowerColor;                     //下衣颜色 {黑，蓝，绿，白/灰，黄/橙/棕，红/粉/紫}  
        public int shape;                          //体型{standard, fat, thin}
        public int mouthmask;                      //口罩{no,yes}  
        public int hair;                           //发型{ long, short }
        public int backpack;                       //背包{no,yes} 
        public int carry;                          //是否拎东西{no,yes}
        public int satchel;                        //斜挎包{no,yes} 
        public int umbrella;                       //雨伞{no,yes}
        public int frontpack;                      //前面背包{no,yes}
        public int luggage;                        //行李箱{no,yes} 

        public META_MOVE_DIRECT_E enMoveDirect;    //行进方向{direct_unknow,forward,backward}
        public META_MOVE_SPEED_E enMoveSpeed;      //行进速度{speed_unknow,slow,fast}
    }


    /// <summary>
    /// 车牌信息
    /// </summary>
    public struct PU_PLATE_INFO_S
    {
        public bool bHavePlate;          //是否抓拍到车牌
        public int iConfidence;          //车牌置信度
        public int iPlateCharNum;                //车牌字符数
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string[] szPlateChar;             //车牌字符，从24扩充到36字节
        public PU_AREA_INFO_S stPlateLoc;    //车牌位置
        public PU_PLATE_TYPE_E enPlateType;      //车牌类型
        public PU_PLATE_COLOR_E enPlateColor;    //车牌颜色
        public PU_PLATE_DIR_E enMoveDir;     //车牌移动方向 
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64 - 12, ArraySubType = UnmanagedType.I1)]
        public byte[] szReserved;         //预留字段，由于车牌字符szPlateChar扩充12字节，此处减少12字节
    }


    public struct PU_UserData
    {
        public LAYER_THREE_TYPE_E eType;
        [StructLayout(LayoutKind.Auto)]
        struct unMetaData
        {
            public bool bBoolValue;
            public byte[] charValue;
            public byte[] ucharValue;
            public short shortValue;
            public ushort ushortValue;
            public int IntValue;
            public uint uIntValue;
            public long longlongValue;
            public long uLonglongValue;
            public byte[] stBinay;
            public META_RECT_S stRec;
            public META_POINT_S stPoint;
            public META_LINE_S stLine;
            public META_POLYGON_S stPolyGon;
            public META_COLOR_S stColor;
            public META_HUMAN_ATTRIBUTES_S stHumanAttr;
            public META_FACE_ATTRIBUTES_S stFaceAttr;
            public META_FACE_INFO_S stFaceInfo;
            public byte[] szUserData;
        }

    }
    /// <summary>
    /// 人脸属性
    /// </summary>
    public struct META_FACE_ATTRIBUTES_S
    {
        public bool isVaild;

        //INT 定义的属性 0 代表 未知，1-n依次代表后面的属性具体含义
        public int glasses;              //眼镜{无，有} 
        public int gender;               //性别{女，男} 
        public int age;                  //年龄，具体的年龄值1~99 
        public int mouthmask;            //遮档 {无，是} 
        public int expression;           //人脸表情{微笑、愤怒、悲伤、正常、惊讶}
    }
    public struct META_FACE_INFO_S
    {
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_MAX_RECORD_LEN_64, ArraySubType = UnmanagedType.I1)]
        public byte[] name;    //名字
        public int iGender;      //性别
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_MAX_RECORD_LEN_32, ArraySubType = UnmanagedType.I1)]
        public byte[] birthday;//生日
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_MAX_RECORD_LEN_32, ArraySubType = UnmanagedType.I1)]
        public byte[] province;//省级
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_MAX_RECORD_LEN_48, ArraySubType = UnmanagedType.I1)]
        public byte[] city;    //地市
        public int iCardType;    //证件类型，参见PU_CARDTYPE_E
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PU_MAX_RECORD_LEN_32, ArraySubType = UnmanagedType.I1)]
        public byte[] cardID;  //证件号
    }


    /// <summary>
    /// 元数据获取相关参数
    /// </summary>
    public struct PU_META_DATA
    {

        public ushort usCapacity;
        public ushort usValidNumber;
        public PU_UserData pstMetaUserData;
    }



    /// <summary>
    /// 时间信息
    /// </summary>
    public struct PU_TIME_S
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string szYear;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string szMonth;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string szDay;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string szHour;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string szMinute;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string szSecond;
    }


    /// <summary>
    /// 实时浏览参数
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct PU_REAL_PLAY_INFO_S
    {
        public UInt32 ulChannelId;
        public IntPtr hPlayWnd;
        public PU_STREAM_TYPE_E enStreamType;
        public PU_VIDEO_TYPE_E enVideoType;
        public PU_PROTOCOL_TYPE_E enProtocolType;
        public PU_MEDIA_CALLBACK_TYPE_E enMediaCallbackType;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_IP4_ADDR_LEN)]
        public string szLocalIp;
        public bool bKeepLive;
        public PU_TIME_S stStartTime;
        public PU_TIME_S stEndTime;
        public PU_MEDIA_CRYPTO_TYPE_E enMediaCryptoType;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_CRYPTION_PASSWD_LEN)]
        public string szMediaCrypto;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_RESERVE_LEN)]
        public string szReserved;

    }

    /// <summary>
    /// 实时浏览扩展参数
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct PU_REAL_PLAY_INFO_V20_S
    {
        public UInt32 ulChannelId;
        public IntPtr hPlayWnd;
        public PU_STREAM_TYPE_E enStreamType;
        public PU_VIDEO_TYPE_E enVideoType;
        public PU_PROTOCOL_TYPE_E enProtocolType;
        public PU_MEDIA_CALLBACK_TYPE_E enMediaCallbackType;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_IP6_ADDR_LEN)]
        public string szLocalIp;
        public bool bKeepLive;
        public PU_TIME_S stStartTime;
        public PU_TIME_S stEndTime;
        public int enIGTDataType;//没有找到PU_IGT_DATA_TYPE_E的说明
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_IP6_ADDR_LEN)]
        public string szMulticastIP;
        public int ulMulticastPort;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PU_RESERVE_LEN)]
        public string szReserved;
    }

    #endregion

    public delegate void REALDATACALLBACK(ref byte[] szBuffer, int lSize, IntPtr pUsrData);
    public delegate int GETALARMINFOCALLBACK_V20(ref PU_ALARM_REPORT_S pstAlarmReport, IntPtr pAlarmInfo, int ulAlarmInfoSize, IntPtr pUsrData);
    public delegate int pfGetAlarmInfoCallBack(ref PU_ALARM_REPORT_S pstAlarmReport);
    public delegate int GETALARMINFOCALLBACK(ref PU_ALARM_REPORT_S fAlarmResportCallBack);

    public delegate int GETDEVALARMINFOCALLBACK(ref PU_ALARM_REPORT_S pstDevAlarmReport, IntPtr pUsrData);



    #region"通用接口"
    #region"SDK初始化"
    /// <summary>
    /// 初始化SDK资源
    /// </summary>
    /// <param name="ulLinkMode">前端的连接模式</param>
    /// <param name="szLocalIP">SDK所在设备的IP地址</param>
    /// <param name="ulLocalPort">SDK所在设备的端口号</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern bool IVS_PU_Init(int ulLinkMode, String szLocalIP, int ulLocalPort);
    /// <summary>
    /// 释放SDK资源
    /// </summary>
    /// <returns></returns>

    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern bool IVS_PU_Cleanup();
    #endregion
    #region"登录/登出"
    /// <summary>
    /// 用户注册至前端设备
    /// </summary>
    /// <param name="szLoginIP">前端设备IP地址</param>
    /// <param name="ulLoginPort">前端设备端口号</param>
    /// <param name="szUserName">登录的用户名</param>
    /// <param name="szPasswd">用户密码</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern UInt32 IVS_PU_Login(string szLoginIP, int ulLoginPort, string szUserName, string szPasswd);

    /// <summary>
    /// 用户注销函数
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <returns></returns>

    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern bool IVS_PU_Logout(UInt32 ulIdentifyID);

    #endregion
    #region"SDK本地配置"
    /// <summary>
    /// 获取当前SDK的版本号
    /// </summary>
    /// <param name="pulVersion">SDK版本号</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern bool IVS_PU_GetVersion(ref int pulVersion);
    /// <summary>
    /// 获取当前的错误码
    /// </summary>
    /// <returns>非负整数</returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern int IVS_PU_GetLastError();
    /// <summary>
    /// 获取对应错误码的出错信息
    /// </summary>
    /// <param name="ulErrorNo">错误码</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern IntPtr IVS_PU_GetErrorMsg(int ulErrorNo);
    #endregion
    #region"自动重连"
    /// <summary>
    /// 设置是否自动重连
    /// </summary>
    /// <param name="bEnable">使能</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern bool IVS_PU_SetAutoReconnect(bool bEnable);
    #endregion
    #endregion
    #region"媒体类接口"
    #region"实况"
    /// <summary>
    /// 实况播放
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="pstRealPlayInfo">实时浏览结构体</param>
    /// <param name="fRealDataCallBack">实况视频流数据回调函数</param>
    /// <param name="pUsrData">用户数据</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern int IVS_PU_RealPlay(UInt32 ulIdentifyID, ref PU_REAL_PLAY_INFO_S pstRealPlayInfo, REALDATACALLBACK fRealDataCallBack, IntPtr pUsrData);
    /// <summary>
    /// 实况播放
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="pstRealPlayInfo">实时浏览结构体</param>
    /// <param name="pstMediaEncPara">媒体加密参数？PU_MEDIA_ENC_PARA_S</param>
    /// <param name="fRealDataCallBack">实况视频流数据回调函数</param>
    /// <param name="pUsrData">用户数据</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern int IVS_PU_RealPlay_V20(UInt32 ulIdentifyID, ref PU_REAL_PLAY_INFO_V20_S pstRealPlayInfo, ref PU_MEDIA_CRYPTO_TYPE_E pstMediaEncPara, REALDATACALLBACK fRealDataCallBack, IntPtr pUsrData);
    /// <summary>
    /// 停止实时预览
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="ulRealHandle">实时播放句柄</param>
    /// <returns></returns>
    [DllImportAttribute(@"HWPuSDK.dll")]
    public static extern bool IVS_PU_StopRealPlay(UInt32 ulIdentifyID, int ulRealHandle);
    #endregion
    #endregion
    #region "告警类接口"
    #region "告警回调"
    /// <summary>
    /// 设置设备告警回调函数
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="fAlarmResportCallBack">告警上报回调函数</param>
    /// <param name="pUsrData">用户数据</param>
    /// <returns></returns>
    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_AlarmInfoStatesCallBack(UInt32 ulIdentifyID, pfGetAlarmInfoCallBack fAlarmResportCallBack, IntPtr pUsrData);

    /// <summary>
    /// 新设置设备告警回调函数
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="fAlarmResportCallBack">告警上报回调函数</param>
    /// <param name="pUsrData">用户数据</param>
    /// <returns></returns>
    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_AlarmInfoStatesCallBack_V20(UInt32 ulIdentifyID, GETALARMINFOCALLBACK_V20 fAlarmResportCallBack, IntPtr pUsrData);


    /// <summary>
    /// 设置设备告警事件回调函数
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="fDevAlarmResportCallBack">告警上报回调函数</param>
    /// <param name="pUsrData">用户数据</param>
    /// <returns></returns>
    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_SetAlarmEnventCallBack(UInt32 ulIdentifyID, GETDEVALARMINFOCALLBACK fDevAlarmResportCallBack, IntPtr pUsrData);
    #endregion
    #region "告警参数配置"

    /// <summary>
    /// 布置或者撤消告警
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="pstGuardPara">布防参数</param>
    /// <returns></returns>
    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_GuardAlarm(UInt32 ulIdentifyID, ref PU_GUARD_PARA_S pstGuardPara);
    /// <summary>
    /// 获取布防状态信息
    /// </summary>
    /// <param name="ulIdentifyID">用户ID号</param>
    /// <param name="pstGuardStates">告警布防状态结构体</param>
    /// <returns></returns>
    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_GetGuardState(UInt32 ulIdentifyID, PU_GUARD_STATE_S pstGuardStates);
    #endregion
    #endregion
    #region"智能分析类接口"
    #region"人脸检测"

    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_User_GetMetaData(byte[] pFBuffer, UInt32 ulFBLength, LAYER_TWO_TYPE_E eLayTwo, PU_META_DATA ppstMetaData);

    [DllImportAttribute("HWPuSDK.dll")]
    public static extern void IVS_User_FreeMetaData(PU_META_DATA ppstMetaData);
    #endregion
    #endregion

    #region""







    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_RecvVLPRDataStart(UInt32 ulIdentifyID);

    [DllImportAttribute("HWPuSDK.dll")]
    public static extern bool IVS_PU_RecvVLPRDataStop(UInt32 ulIdentifyID);

    #endregion
}

/*
 ，[DLLImport(“SDK path/HWPuSDK.dll”), EntryPoint = “SdkFunctionName”, CharSet = CharSet.Ansi, SetLastError = true, PreserveSig = ture, CallingConvention = CallingConvention.StdCall)]。
     
     */
