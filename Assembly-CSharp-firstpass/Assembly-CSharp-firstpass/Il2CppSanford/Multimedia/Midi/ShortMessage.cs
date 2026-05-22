using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001BF RID: 447
	public class ShortMessage : MidiMessageBase
	{
		// Token: 0x06001599 RID: 5529 RVA: 0x00062E18 File Offset: 0x00061018
		// Note: this type is marked as 'beforefieldinit'.
		static ShortMessage()
		{
			Il2CppClassPointerStore<ShortMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "ShortMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr);
			ShortMessage.NativeFieldInfoPtr_DataMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "DataMaxValue");
			ShortMessage.NativeFieldInfoPtr_StatusMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "StatusMaxValue");
			ShortMessage.NativeFieldInfoPtr_StatusMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "StatusMask");
			ShortMessage.NativeFieldInfoPtr_DataMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "DataMask");
			ShortMessage.NativeFieldInfoPtr_Data1Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "Data1Mask");
			ShortMessage.NativeFieldInfoPtr_Data2Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "Data2Mask");
			ShortMessage.NativeFieldInfoPtr_Shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "Shift");
			ShortMessage.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "msg");
			ShortMessage.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "message");
			ShortMessage.NativeFieldInfoPtr_rawMessageBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "rawMessageBuilt");
			ShortMessage.NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, "<Timestamp>k__BackingField");
			ShortMessage.NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666370);
			ShortMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666371);
			ShortMessage.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666372);
			ShortMessage.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666373);
			ShortMessage.NativeMethodInfoPtr_BuildByteMessage_Private_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666374);
			ShortMessage.NativeMethodInfoPtr_BuildIntMessage_Private_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666375);
			ShortMessage.NativeMethodInfoPtr_PackStatus_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666376);
			ShortMessage.NativeMethodInfoPtr_PackData1_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666377);
			ShortMessage.NativeMethodInfoPtr_PackData2_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666378);
			ShortMessage.NativeMethodInfoPtr_UnpackStatus_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666379);
			ShortMessage.NativeMethodInfoPtr_UnpackData1_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666380);
			ShortMessage.NativeMethodInfoPtr_UnpackData2_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666381);
			ShortMessage.NativeMethodInfoPtr_get_Timestamp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666382);
			ShortMessage.NativeMethodInfoPtr_set_Timestamp_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666383);
			ShortMessage.NativeMethodInfoPtr_get_Message_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666384);
			ShortMessage.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666385);
			ShortMessage.NativeMethodInfoPtr_get_Bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666386);
			ShortMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_New_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr, 100666387);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0006308C File Offset: 0x0006128C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16840, RefRangeEnd = 16842, XrefRangeStart = 16837, XrefRangeEnd = 16840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000630CC File Offset: 0x000612CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00063108 File Offset: 0x00061308
		[CallerCount(0)]
		public unsafe ShortMessage(int message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00063150 File Offset: 0x00061350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16848, RefRangeEnd = 16849, XrefRangeStart = 16842, XrefRangeEnd = 16848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShortMessage(byte status, byte data1, byte data2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000631B4 File Offset: 0x000613B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16849, XrefRangeEnd = 16852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> BuildByteMessage(int intMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intMessage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_BuildByteMessage_Private_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000631F4 File Offset: 0x000613F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16852, XrefRangeEnd = 16862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BuildIntMessage(Il2CppStructArray<byte> message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_BuildIntMessage_Private_Static_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00063238 File Offset: 0x00061438
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 16862, RefRangeEnd = 16866, XrefRangeStart = 16862, XrefRangeEnd = 16862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PackStatus(int message, int status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_PackStatus_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00063284 File Offset: 0x00061484
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 16866, RefRangeEnd = 16880, XrefRangeStart = 16866, XrefRangeEnd = 16866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PackData1(int message, int data1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_PackData1_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000632D0 File Offset: 0x000614D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 16880, RefRangeEnd = 16890, XrefRangeStart = 16880, XrefRangeEnd = 16880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PackData2(int message, int data2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_PackData2_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0006331C File Offset: 0x0006151C
		[CallerCount(0)]
		public unsafe static int UnpackStatus(int message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_UnpackStatus_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0006335C File Offset: 0x0006155C
		[CallerCount(0)]
		public unsafe static int UnpackData1(int message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_UnpackData1_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0006339C File Offset: 0x0006159C
		[CallerCount(0)]
		public unsafe static int UnpackData2(int message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_UnpackData2_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000633DC File Offset: 0x000615DC
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00063418 File Offset: 0x00061618
		public unsafe int Timestamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_get_Timestamp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_set_Timestamp_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00063458 File Offset: 0x00061658
		public unsafe int Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_get_Message_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00063494 File Offset: 0x00061694
		public unsafe virtual int Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x000634D0 File Offset: 0x000616D0
		public unsafe Il2CppStructArray<byte> Bytes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 16840, RefRangeEnd = 16842, XrefRangeStart = 16840, XrefRangeEnd = 16842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortMessage.NativeMethodInfoPtr_get_Bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00063510 File Offset: 0x00061710
		public unsafe virtual MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShortMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_New_get_MessageType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00008B1E File Offset: 0x00006D1E
		public ShortMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00063558 File Offset: 0x00061758
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x00008B27 File Offset: 0x00006D27
		public unsafe static int DataMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_DataMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_DataMaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00063574 File Offset: 0x00061774
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00008B35 File Offset: 0x00006D35
		public unsafe static int StatusMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_StatusMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_StatusMaxValue, (void*)(&value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00063590 File Offset: 0x00061790
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00008B43 File Offset: 0x00006D43
		public unsafe static int StatusMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_StatusMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_StatusMask, (void*)(&value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000635AC File Offset: 0x000617AC
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00008B51 File Offset: 0x00006D51
		public unsafe static int DataMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_DataMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_DataMask, (void*)(&value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000635C8 File Offset: 0x000617C8
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00008B5F File Offset: 0x00006D5F
		public unsafe static int Data1Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_Data1Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_Data1Mask, (void*)(&value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000635E4 File Offset: 0x000617E4
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x00008B6D File Offset: 0x00006D6D
		public unsafe static int Data2Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_Data2Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_Data2Mask, (void*)(&value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x00063600 File Offset: 0x00061800
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x00008B7B File Offset: 0x00006D7B
		public unsafe static int Shift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShortMessage.NativeFieldInfoPtr_Shift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShortMessage.NativeFieldInfoPtr_Shift, (void*)(&value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0006361C File Offset: 0x0006181C
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x00008B89 File Offset: 0x00006D89
		public unsafe int msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr_msg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr_msg)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00063644 File Offset: 0x00061844
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00008BA4 File Offset: 0x00006DA4
		public unsafe Il2CppStructArray<byte> message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00063674 File Offset: 0x00061874
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x00008BC3 File Offset: 0x00006DC3
		public unsafe bool rawMessageBuilt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr_rawMessageBuilt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr_rawMessageBuilt)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0006369C File Offset: 0x0006189C
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x00008BDE File Offset: 0x00006DDE
		public unsafe int _Timestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr__Timestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShortMessage.NativeFieldInfoPtr__Timestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeFieldInfoPtr_DataMaxValue;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeFieldInfoPtr_StatusMaxValue;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeFieldInfoPtr_StatusMask;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeFieldInfoPtr_DataMask;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeFieldInfoPtr_Data1Mask;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeFieldInfoPtr_Data2Mask;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeFieldInfoPtr_Shift;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeFieldInfoPtr_msg;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_rawMessageBuilt;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_BuildByteMessage_Private_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_BuildIntMessage_Private_Static_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_PackStatus_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_PackData1_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_PackData2_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_UnpackStatus_Internal_Static_Int32_Int32_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_UnpackData1_Internal_Static_Int32_Int32_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_UnpackData2_Internal_Static_Int32_Int32_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_get_Timestamp_Public_get_Int32_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_set_Timestamp_Internal_set_Void_Int32_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_Int32_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_get_Bytes_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Virtual_New_get_MessageType_0;
	}
}
