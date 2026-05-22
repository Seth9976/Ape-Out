using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia
{
	// Token: 0x02000181 RID: 385
	public class DeviceException : ApplicationException
	{
		// Token: 0x06001138 RID: 4408 RVA: 0x00053918 File Offset: 0x00051B18
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceException()
		{
			Il2CppClassPointerStore<DeviceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia", "DeviceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceException>.NativeClassPtr);
			DeviceException.NativeFieldInfoPtr_MMSYSERR_NOERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_NOERROR");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_ERROR");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_BADDEVICEID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_BADDEVICEID");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_NOTENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_NOTENABLED");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_ALLOCATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_ALLOCATED");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALHANDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_INVALHANDLE");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_NODRIVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_NODRIVER");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_NOMEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_NOMEM");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_NOTSUPPORTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_NOTSUPPORTED");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_BADERRNUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_BADERRNUM");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALFLAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_INVALFLAG");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALPARAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_INVALPARAM");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_HANDLEBUSY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_HANDLEBUSY");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALIDALIAS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_INVALIDALIAS");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_BADDB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_BADDB");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_KEYNOTFOUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_KEYNOTFOUND");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_READERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_READERROR");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_WRITEERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_WRITEERROR");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_DELETEERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_DELETEERROR");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_VALNOTFOUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_VALNOTFOUND");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_NODRIVERCB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_NODRIVERCB");
			DeviceException.NativeFieldInfoPtr_MMSYSERR_LASTERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "MMSYSERR_LASTERROR");
			DeviceException.NativeFieldInfoPtr_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, "errorCode");
			DeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, 100665804);
			DeviceException.NativeMethodInfoPtr_get_ErrorCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceException>.NativeClassPtr, 100665805);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00053B3C File Offset: 0x00051D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14106, XrefRangeEnd = 14107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceException(int errorCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00053B84 File Offset: 0x00051D84
		public unsafe int ErrorCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceException.NativeMethodInfoPtr_get_ErrorCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00007146 File Offset: 0x00005346
		public DeviceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00053BC0 File Offset: 0x00051DC0
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0000714F File Offset: 0x0000534F
		public unsafe static int MMSYSERR_NOERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOERROR, (void*)(&value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00053BDC File Offset: 0x00051DDC
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0000715D File Offset: 0x0000535D
		public unsafe static int MMSYSERR_ERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_ERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_ERROR, (void*)(&value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00053BF8 File Offset: 0x00051DF8
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0000716B File Offset: 0x0000536B
		public unsafe static int MMSYSERR_BADDEVICEID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_BADDEVICEID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_BADDEVICEID, (void*)(&value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00053C14 File Offset: 0x00051E14
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x00007179 File Offset: 0x00005379
		public unsafe static int MMSYSERR_NOTENABLED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOTENABLED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOTENABLED, (void*)(&value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00053C30 File Offset: 0x00051E30
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x00007187 File Offset: 0x00005387
		public unsafe static int MMSYSERR_ALLOCATED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_ALLOCATED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_ALLOCATED, (void*)(&value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00053C4C File Offset: 0x00051E4C
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x00007195 File Offset: 0x00005395
		public unsafe static int MMSYSERR_INVALHANDLE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALHANDLE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALHANDLE, (void*)(&value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00053C68 File Offset: 0x00051E68
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x000071A3 File Offset: 0x000053A3
		public unsafe static int MMSYSERR_NODRIVER
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NODRIVER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NODRIVER, (void*)(&value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00053C84 File Offset: 0x00051E84
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x000071B1 File Offset: 0x000053B1
		public unsafe static int MMSYSERR_NOMEM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOMEM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOMEM, (void*)(&value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00053CA0 File Offset: 0x00051EA0
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x000071BF File Offset: 0x000053BF
		public unsafe static int MMSYSERR_NOTSUPPORTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOTSUPPORTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NOTSUPPORTED, (void*)(&value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00053CBC File Offset: 0x00051EBC
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x000071CD File Offset: 0x000053CD
		public unsafe static int MMSYSERR_BADERRNUM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_BADERRNUM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_BADERRNUM, (void*)(&value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00053CD8 File Offset: 0x00051ED8
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x000071DB File Offset: 0x000053DB
		public unsafe static int MMSYSERR_INVALFLAG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALFLAG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALFLAG, (void*)(&value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00053CF4 File Offset: 0x00051EF4
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x000071E9 File Offset: 0x000053E9
		public unsafe static int MMSYSERR_INVALPARAM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALPARAM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALPARAM, (void*)(&value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00053D10 File Offset: 0x00051F10
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x000071F7 File Offset: 0x000053F7
		public unsafe static int MMSYSERR_HANDLEBUSY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_HANDLEBUSY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_HANDLEBUSY, (void*)(&value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00053D2C File Offset: 0x00051F2C
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00007205 File Offset: 0x00005405
		public unsafe static int MMSYSERR_INVALIDALIAS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALIDALIAS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_INVALIDALIAS, (void*)(&value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00053D48 File Offset: 0x00051F48
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00007213 File Offset: 0x00005413
		public unsafe static int MMSYSERR_BADDB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_BADDB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_BADDB, (void*)(&value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00053D64 File Offset: 0x00051F64
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00007221 File Offset: 0x00005421
		public unsafe static int MMSYSERR_KEYNOTFOUND
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_KEYNOTFOUND, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_KEYNOTFOUND, (void*)(&value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00053D80 File Offset: 0x00051F80
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x0000722F File Offset: 0x0000542F
		public unsafe static int MMSYSERR_READERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_READERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_READERROR, (void*)(&value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00053D9C File Offset: 0x00051F9C
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0000723D File Offset: 0x0000543D
		public unsafe static int MMSYSERR_WRITEERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_WRITEERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_WRITEERROR, (void*)(&value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00053DB8 File Offset: 0x00051FB8
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0000724B File Offset: 0x0000544B
		public unsafe static int MMSYSERR_DELETEERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_DELETEERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_DELETEERROR, (void*)(&value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00053DD4 File Offset: 0x00051FD4
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00007259 File Offset: 0x00005459
		public unsafe static int MMSYSERR_VALNOTFOUND
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_VALNOTFOUND, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_VALNOTFOUND, (void*)(&value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00053DF0 File Offset: 0x00051FF0
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00007267 File Offset: 0x00005467
		public unsafe static int MMSYSERR_NODRIVERCB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NODRIVERCB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_NODRIVERCB, (void*)(&value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00053E0C File Offset: 0x0005200C
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00007275 File Offset: 0x00005475
		public unsafe static int MMSYSERR_LASTERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_LASTERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceException.NativeFieldInfoPtr_MMSYSERR_LASTERROR, (void*)(&value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00053E28 File Offset: 0x00052028
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00007283 File Offset: 0x00005483
		public unsafe int errorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceException.NativeFieldInfoPtr_errorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceException.NativeFieldInfoPtr_errorCode)) = value;
			}
		}

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_NOERROR;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_ERROR;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_BADDEVICEID;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_NOTENABLED;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_ALLOCATED;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_INVALHANDLE;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_NODRIVER;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_NOMEM;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_NOTSUPPORTED;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_BADERRNUM;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_INVALFLAG;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_INVALPARAM;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_HANDLEBUSY;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_INVALIDALIAS;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_BADDB;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_KEYNOTFOUND;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_READERROR;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_WRITEERROR;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_DELETEERROR;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_VALNOTFOUND;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_NODRIVERCB;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeFieldInfoPtr_MMSYSERR_LASTERROR;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeFieldInfoPtr_errorCode;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_get_Int32_0;
	}
}
