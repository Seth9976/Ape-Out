using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.HID.Drivers
{
	// Token: 0x0200011A RID: 282
	public class RailDriverDriver : HIDDeviceDriver
	{
		// Token: 0x06001CDE RID: 7390 RVA: 0x0009AB64 File Offset: 0x00098D64
		// Note: this type is marked as 'beforefieldinit'.
		static RailDriverDriver()
		{
			Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID.Drivers", "RailDriverDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr);
			RailDriverDriver.NativeFieldInfoPtr_rNmbGNhARvjgZKIkQpqQqjpIJQTl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "rNmbGNhARvjgZKIkQpqQqjpIJQTl");
			RailDriverDriver.NativeFieldInfoPtr_nbxaduvLTEoEFesZaxmSgfLchZc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "nbxaduvLTEoEFesZaxmSgfLchZc");
			RailDriverDriver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
			RailDriverDriver.NativeFieldInfoPtr_HFvGCvIuLYsNzRTkBGAJwzjThtb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "HFvGCvIuLYsNzRTkBGAJwzjThtb");
			RailDriverDriver.NativeFieldInfoPtr_DvDhZqmshngoEPivhBYvHLdpboK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "DvDhZqmshngoEPivhBYvHLdpboK");
			RailDriverDriver.NativeFieldInfoPtr_fZyfdPjQqKkkcSVebEyhQaLpLLjp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "fZyfdPjQqKkkcSVebEyhQaLpLLjp");
			RailDriverDriver.NativeFieldInfoPtr_ytZlbIdVXnFFMXdRjypVdXNqnVU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "ytZlbIdVXnFFMXdRjypVdXNqnVU");
			RailDriverDriver.NativeFieldInfoPtr_dOxqeDsdFrfhzwTbGfUsBKBEZBJh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "dOxqeDsdFrfhzwTbGfUsBKBEZBJh");
			RailDriverDriver.NativeFieldInfoPtr_whRspvVNdJVtjlcaDjxWoUNTiEgc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "whRspvVNdJVtjlcaDjxWoUNTiEgc");
			RailDriverDriver.NativeFieldInfoPtr_XjUMQfByepfYVdsvwPtrbJCczzp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "XjUMQfByepfYVdsvwPtrbJCczzp");
			RailDriverDriver.NativeFieldInfoPtr_egEBBvhxEOYZlzhBnBlpUpvjpfM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "egEBBvhxEOYZlzhBnBlpUpvjpfM");
			RailDriverDriver.NativeFieldInfoPtr_hdTigjHKwDlzluMuQDGMtVDNPNQv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "hdTigjHKwDlzluMuQDGMtVDNPNQv");
			RailDriverDriver.NativeFieldInfoPtr_qxImuLeFrPcqPAmwGjbqNvjNCVvh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "qxImuLeFrPcqPAmwGjbqNvjNCVvh");
			RailDriverDriver.NativeFieldInfoPtr_jejhJbrQyWVzLhJjoOtaODfFfcy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "jejhJbrQyWVzLhJjoOtaODfFfcy");
			RailDriverDriver.NativeFieldInfoPtr_oCtnImchjPanpoKkKkzFsSoKoLm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "oCtnImchjPanpoKkKkzFsSoKoLm");
			RailDriverDriver.NativeFieldInfoPtr_xkyARxfRgFDsHOMCOJYkqatjoEKr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "xkyARxfRgFDsHOMCOJYkqatjoEKr");
			RailDriverDriver.NativeFieldInfoPtr_PSSsMJSEVQcgjXoISlNGvDIYifF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "PSSsMJSEVQcgjXoISlNGvDIYifF");
			RailDriverDriver.NativeFieldInfoPtr_yGmjjduNfUNOOFFOCrLQqdjzxFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "yGmjjduNfUNOOFFOCrLQqdjzxFS");
			RailDriverDriver.NativeFieldInfoPtr_JvzRCKahnKoqsutkjSFAZMZfBC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "JvzRCKahnKoqsutkjSFAZMZfBC");
			RailDriverDriver.NativeFieldInfoPtr_vUEkuwZbpNbiELyQyPDbOnoHhmAB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "vUEkuwZbpNbiELyQyPDbOnoHhmAB");
			RailDriverDriver.NativeFieldInfoPtr_EwUgejggsLhULiehkLKxPYKkBBzT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "EwUgejggsLhULiehkLKxPYKkBBzT");
			RailDriverDriver.NativeFieldInfoPtr_qOHSdYkcdmfjHhNagxZrjjhxjObi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "qOHSdYkcdmfjHhNagxZrjjhxjObi");
			RailDriverDriver.NativeFieldInfoPtr_eRBDMtvMCBzsxKbrAYSCWbIjFmK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "eRBDMtvMCBzsxKbrAYSCWbIjFmK");
			RailDriverDriver.NativeFieldInfoPtr_iquKSAmTldnHqdYvyFtjnGkrKki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "iquKSAmTldnHqdYvyFtjnGkrKki");
			RailDriverDriver.NativeFieldInfoPtr_dTImBCFGcurFCuifqFvSCmOHXYG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "dTImBCFGcurFCuifqFvSCmOHXYG");
			RailDriverDriver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "VqjireeisHBGAbOmixQcKOQABZY");
			RailDriverDriver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "SEQenGfoIoNZmaGLiQDgmYcHfBRG");
			RailDriverDriver.NativeFieldInfoPtr_qLZLrvgGKIFHrTOhgJYquifqrAF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "qLZLrvgGKIFHrTOhgJYquifqrAF");
			RailDriverDriver.NativeFieldInfoPtr_DfQQCBEQohpFufJdsvMsKUXgsBP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "DfQQCBEQohpFufJdsvMsKUXgsBP");
			RailDriverDriver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "NXVqXgfUsQHbVRrEpuYEreBlzpN");
			RailDriverDriver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "dzydtpDkcOlbZPaRhVbfGNBdrDQ");
			RailDriverDriver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, "MqcIIdsSwUqQdRoXaTgVghcDhrW");
			RailDriverDriver.NativeMethodInfoPtr_get_SpeakerEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669706);
			RailDriverDriver.NativeMethodInfoPtr_set_SpeakerEnabled_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669707);
			RailDriverDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Virtual_Final_New_Void_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669708);
			RailDriverDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Virtual_Final_New_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669709);
			RailDriverDriver.NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669710);
			RailDriverDriver.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669711);
			RailDriverDriver.NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669712);
			RailDriverDriver.NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669713);
			RailDriverDriver.NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_vdLqCHUeLIhADCaHyDRzKpAFqYBh_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669714);
			RailDriverDriver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_vdLqCHUeLIhADCaHyDRzKpAFqYBh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669715);
			RailDriverDriver.NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669716);
			RailDriverDriver.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669717);
			RailDriverDriver.NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669718);
			RailDriverDriver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669719);
			RailDriverDriver.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669720);
			RailDriverDriver.NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr, 100669721);
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0009AF54 File Offset: 0x00099154
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0009AF90 File Offset: 0x00099190
		public unsafe virtual bool SpeakerEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_get_SpeakerEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280219, XrefRangeEnd = 280226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_set_SpeakerEnabled_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0009AFD0 File Offset: 0x000991D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280226, XrefRangeEnd = 280231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLEDDisplay(int digitIndex, byte digitBitValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digitIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitBitValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Virtual_Final_New_Void_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0009B01C File Offset: 0x0009921C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280231, XrefRangeEnd = 280236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit1BitValues;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digit2BitValues;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digit3BitValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_SetLEDDisplay_Public_Virtual_Final_New_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0009B078 File Offset: 0x00099278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280303, RefRangeEnd = 280304, XrefRangeStart = 280236, XrefRangeEnd = 280303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RailDriverDriver(HIDDeviceDriver.InitArgs initArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RailDriverDriver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0009B0C4 File Offset: 0x000992C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RailDriverDriver.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0009B110 File Offset: 0x00099310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280304, XrefRangeEnd = 280309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputReportPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputReportLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RailDriverDriver.NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0009B180 File Offset: 0x00099380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280309, XrefRangeEnd = 280316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension CreateControllerExtension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RailDriverDriver.NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0009B1CC File Offset: 0x000993CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280316, XrefRangeEnd = 280321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool zNXomrMcpdzggtTitEdjWdzqgEbj(RailDriverDriver.vdLqCHUeLIhADCaHyDRzKpAFqYBh A_1, rBapAxSjeCWOiOHyzennMIRNCHfj A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_vdLqCHUeLIhADCaHyDRzKpAFqYBh_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0009B224 File Offset: 0x00099424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 280341, RefRangeEnd = 280344, XrefRangeStart = 280321, XrefRangeEnd = 280341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IuZFpZfntxLYutBfTAuqVYKxfjj(RailDriverDriver.vdLqCHUeLIhADCaHyDRzKpAFqYBh A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_vdLqCHUeLIhADCaHyDRzKpAFqYBh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0009B264 File Offset: 0x00099464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280344, XrefRangeEnd = 280348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool bWlObuwhPuWKIEdjMaLCkLFuAubl(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0009B2B0 File Offset: 0x000994B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280352, RefRangeEnd = 280353, XrefRangeStart = 280348, XrefRangeEnd = 280352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QLZdJmwnUkddZisUnLmixtMACSh(NativeBuffer A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0009B300 File Offset: 0x00099500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void gbHdOZilzwmhPaLsoSTdCfNBZKKu(Il2CppReferenceArray<HIDControllerElement> A_1, NativeBuffer A_2, double A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0009B364 File Offset: 0x00099564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RailDriverDriver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0009B3A0 File Offset: 0x000995A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280353, XrefRangeEnd = 280355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RailDriverDriver.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0009B3EC File Offset: 0x000995EC
		[CallerCount(0)]
		public unsafe static bool Matches(int vid, int pid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RailDriverDriver.NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000BE50 File Offset: 0x0000A050
		public RailDriverDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0009B438 File Offset: 0x00099638
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0000BE59 File Offset: 0x0000A059
		public unsafe static int rNmbGNhARvjgZKIkQpqQqjpIJQTl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_rNmbGNhARvjgZKIkQpqQqjpIJQTl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_rNmbGNhARvjgZKIkQpqQqjpIJQTl, (void*)(&value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0009B454 File Offset: 0x00099654
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0000BE67 File Offset: 0x0000A067
		public unsafe static int nbxaduvLTEoEFesZaxmSgfLchZc
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_nbxaduvLTEoEFesZaxmSgfLchZc, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_nbxaduvLTEoEFesZaxmSgfLchZc, (void*)(&value));
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0009B470 File Offset: 0x00099670
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0000BE75 File Offset: 0x0000A075
		public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0009B48C File Offset: 0x0009968C
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0000BE83 File Offset: 0x0000A083
		public unsafe static int HFvGCvIuLYsNzRTkBGAJwzjThtb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_HFvGCvIuLYsNzRTkBGAJwzjThtb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_HFvGCvIuLYsNzRTkBGAJwzjThtb, (void*)(&value));
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x0009B4A8 File Offset: 0x000996A8
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0000BE91 File Offset: 0x0000A091
		public unsafe static int DvDhZqmshngoEPivhBYvHLdpboK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_DvDhZqmshngoEPivhBYvHLdpboK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_DvDhZqmshngoEPivhBYvHLdpboK, (void*)(&value));
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0009B4C4 File Offset: 0x000996C4
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0000BE9F File Offset: 0x0000A09F
		public unsafe static int fZyfdPjQqKkkcSVebEyhQaLpLLjp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_fZyfdPjQqKkkcSVebEyhQaLpLLjp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_fZyfdPjQqKkkcSVebEyhQaLpLLjp, (void*)(&value));
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0009B4E0 File Offset: 0x000996E0
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000BEAD File Offset: 0x0000A0AD
		public unsafe static int ytZlbIdVXnFFMXdRjypVdXNqnVU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_ytZlbIdVXnFFMXdRjypVdXNqnVU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_ytZlbIdVXnFFMXdRjypVdXNqnVU, (void*)(&value));
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0009B4FC File Offset: 0x000996FC
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000BEBB File Offset: 0x0000A0BB
		public unsafe static int dOxqeDsdFrfhzwTbGfUsBKBEZBJh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_dOxqeDsdFrfhzwTbGfUsBKBEZBJh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_dOxqeDsdFrfhzwTbGfUsBKBEZBJh, (void*)(&value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0009B518 File Offset: 0x00099718
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000BEC9 File Offset: 0x0000A0C9
		public unsafe static int whRspvVNdJVtjlcaDjxWoUNTiEgc
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_whRspvVNdJVtjlcaDjxWoUNTiEgc, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_whRspvVNdJVtjlcaDjxWoUNTiEgc, (void*)(&value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0009B534 File Offset: 0x00099734
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0000BED7 File Offset: 0x0000A0D7
		public unsafe static int XjUMQfByepfYVdsvwPtrbJCczzp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_XjUMQfByepfYVdsvwPtrbJCczzp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_XjUMQfByepfYVdsvwPtrbJCczzp, (void*)(&value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0009B550 File Offset: 0x00099750
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0000BEE5 File Offset: 0x0000A0E5
		public unsafe static int egEBBvhxEOYZlzhBnBlpUpvjpfM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_egEBBvhxEOYZlzhBnBlpUpvjpfM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_egEBBvhxEOYZlzhBnBlpUpvjpfM, (void*)(&value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0009B56C File Offset: 0x0009976C
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000BEF3 File Offset: 0x0000A0F3
		public unsafe static int hdTigjHKwDlzluMuQDGMtVDNPNQv
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_hdTigjHKwDlzluMuQDGMtVDNPNQv, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_hdTigjHKwDlzluMuQDGMtVDNPNQv, (void*)(&value));
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0009B588 File Offset: 0x00099788
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0000BF01 File Offset: 0x0000A101
		public unsafe static int qxImuLeFrPcqPAmwGjbqNvjNCVvh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_qxImuLeFrPcqPAmwGjbqNvjNCVvh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_qxImuLeFrPcqPAmwGjbqNvjNCVvh, (void*)(&value));
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0009B5A4 File Offset: 0x000997A4
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x0000BF0F File Offset: 0x0000A10F
		public unsafe static int jejhJbrQyWVzLhJjoOtaODfFfcy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_jejhJbrQyWVzLhJjoOtaODfFfcy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_jejhJbrQyWVzLhJjoOtaODfFfcy, (void*)(&value));
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x0009B5C0 File Offset: 0x000997C0
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x0000BF1D File Offset: 0x0000A11D
		public unsafe static int oCtnImchjPanpoKkKkzFsSoKoLm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_oCtnImchjPanpoKkKkzFsSoKoLm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_oCtnImchjPanpoKkKkzFsSoKoLm, (void*)(&value));
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0009B5DC File Offset: 0x000997DC
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0000BF2B File Offset: 0x0000A12B
		public unsafe static int xkyARxfRgFDsHOMCOJYkqatjoEKr
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_xkyARxfRgFDsHOMCOJYkqatjoEKr, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_xkyARxfRgFDsHOMCOJYkqatjoEKr, (void*)(&value));
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0009B5F8 File Offset: 0x000997F8
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x0000BF39 File Offset: 0x0000A139
		public unsafe static int PSSsMJSEVQcgjXoISlNGvDIYifF
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_PSSsMJSEVQcgjXoISlNGvDIYifF, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_PSSsMJSEVQcgjXoISlNGvDIYifF, (void*)(&value));
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0009B614 File Offset: 0x00099814
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x0000BF47 File Offset: 0x0000A147
		public unsafe static int yGmjjduNfUNOOFFOCrLQqdjzxFS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_yGmjjduNfUNOOFFOCrLQqdjzxFS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_yGmjjduNfUNOOFFOCrLQqdjzxFS, (void*)(&value));
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0009B630 File Offset: 0x00099830
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x0000BF55 File Offset: 0x0000A155
		public unsafe static int JvzRCKahnKoqsutkjSFAZMZfBC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_JvzRCKahnKoqsutkjSFAZMZfBC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_JvzRCKahnKoqsutkjSFAZMZfBC, (void*)(&value));
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0009B64C File Offset: 0x0009984C
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0000BF63 File Offset: 0x0000A163
		public unsafe static int vUEkuwZbpNbiELyQyPDbOnoHhmAB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_vUEkuwZbpNbiELyQyPDbOnoHhmAB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_vUEkuwZbpNbiELyQyPDbOnoHhmAB, (void*)(&value));
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0009B668 File Offset: 0x00099868
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x0000BF71 File Offset: 0x0000A171
		public unsafe static int EwUgejggsLhULiehkLKxPYKkBBzT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_EwUgejggsLhULiehkLKxPYKkBBzT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_EwUgejggsLhULiehkLKxPYKkBBzT, (void*)(&value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0009B684 File Offset: 0x00099884
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x0000BF7F File Offset: 0x0000A17F
		public unsafe static int qOHSdYkcdmfjHhNagxZrjjhxjObi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_qOHSdYkcdmfjHhNagxZrjjhxjObi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_qOHSdYkcdmfjHhNagxZrjjhxjObi, (void*)(&value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x0009B6A0 File Offset: 0x000998A0
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x0000BF8D File Offset: 0x0000A18D
		public unsafe static int eRBDMtvMCBzsxKbrAYSCWbIjFmK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_eRBDMtvMCBzsxKbrAYSCWbIjFmK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_eRBDMtvMCBzsxKbrAYSCWbIjFmK, (void*)(&value));
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0009B6BC File Offset: 0x000998BC
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x0000BF9B File Offset: 0x0000A19B
		public unsafe static int iquKSAmTldnHqdYvyFtjnGkrKki
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_iquKSAmTldnHqdYvyFtjnGkrKki, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_iquKSAmTldnHqdYvyFtjnGkrKki, (void*)(&value));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0009B6D8 File Offset: 0x000998D8
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0000BFA9 File Offset: 0x0000A1A9
		public unsafe static int dTImBCFGcurFCuifqFvSCmOHXYG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RailDriverDriver.NativeFieldInfoPtr_dTImBCFGcurFCuifqFvSCmOHXYG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RailDriverDriver.NativeFieldInfoPtr_dTImBCFGcurFCuifqFvSCmOHXYG, (void*)(&value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0009B6F4 File Offset: 0x000998F4
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x0000BFB7 File Offset: 0x0000A1B7
		public unsafe NativeBuffer VqjireeisHBGAbOmixQcKOQABZY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0009B724 File Offset: 0x00099924
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
		public unsafe NativeBuffer SEQenGfoIoNZmaGLiQDgmYcHfBRG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0009B754 File Offset: 0x00099954
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0000BFF5 File Offset: 0x0000A1F5
		public unsafe bool qLZLrvgGKIFHrTOhgJYquifqrAF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_qLZLrvgGKIFHrTOhgJYquifqrAF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_qLZLrvgGKIFHrTOhgJYquifqrAF)) = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0009B77C File Offset: 0x0009997C
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x0000C010 File Offset: 0x0000A210
		public unsafe Il2CppStructArray<byte> DfQQCBEQohpFufJdsvMsKUXgsBP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_DfQQCBEQohpFufJdsvMsKUXgsBP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_DfQQCBEQohpFufJdsvMsKUXgsBP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0009B7AC File Offset: 0x000999AC
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0000C02F File Offset: 0x0000A22F
		public unsafe OutputReport NXVqXgfUsQHbVRrEpuYEreBlzpN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0009B7D4 File Offset: 0x000999D4
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0000C04A File Offset: 0x0000A24A
		public unsafe Func<OutputReport, bool> dzydtpDkcOlbZPaRhVbfGNBdrDQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<OutputReport, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0009B804 File Offset: 0x00099A04
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0000C069 File Offset: 0x0000A269
		public unsafe Action<OutputReport> MqcIIdsSwUqQdRoXaTgVghcDhrW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OutputReport>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RailDriverDriver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeFieldInfoPtr_rNmbGNhARvjgZKIkQpqQqjpIJQTl;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr_nbxaduvLTEoEFesZaxmSgfLchZc;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeFieldInfoPtr_HFvGCvIuLYsNzRTkBGAJwzjThtb;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeFieldInfoPtr_DvDhZqmshngoEPivhBYvHLdpboK;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeFieldInfoPtr_fZyfdPjQqKkkcSVebEyhQaLpLLjp;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeFieldInfoPtr_ytZlbIdVXnFFMXdRjypVdXNqnVU;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeFieldInfoPtr_dOxqeDsdFrfhzwTbGfUsBKBEZBJh;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeFieldInfoPtr_whRspvVNdJVtjlcaDjxWoUNTiEgc;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeFieldInfoPtr_XjUMQfByepfYVdsvwPtrbJCczzp;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeFieldInfoPtr_egEBBvhxEOYZlzhBnBlpUpvjpfM;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr_hdTigjHKwDlzluMuQDGMtVDNPNQv;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr_qxImuLeFrPcqPAmwGjbqNvjNCVvh;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeFieldInfoPtr_jejhJbrQyWVzLhJjoOtaODfFfcy;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeFieldInfoPtr_oCtnImchjPanpoKkKkzFsSoKoLm;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeFieldInfoPtr_xkyARxfRgFDsHOMCOJYkqatjoEKr;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr_PSSsMJSEVQcgjXoISlNGvDIYifF;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeFieldInfoPtr_yGmjjduNfUNOOFFOCrLQqdjzxFS;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_JvzRCKahnKoqsutkjSFAZMZfBC;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_vUEkuwZbpNbiELyQyPDbOnoHhmAB;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr_EwUgejggsLhULiehkLKxPYKkBBzT;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr_qOHSdYkcdmfjHhNagxZrjjhxjObi;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr_eRBDMtvMCBzsxKbrAYSCWbIjFmK;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_iquKSAmTldnHqdYvyFtjnGkrKki;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_dTImBCFGcurFCuifqFvSCmOHXYG;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr_qLZLrvgGKIFHrTOhgJYquifqrAF;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr_DfQQCBEQohpFufJdsvMsKUXgsBP;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_get_SpeakerEnabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_set_SpeakerEnabled_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDDisplay_Public_Virtual_Final_New_Void_Int32_Byte_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDDisplay_Public_Virtual_Final_New_Void_Byte_Byte_Byte_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_vdLqCHUeLIhADCaHyDRzKpAFqYBh_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_vdLqCHUeLIhADCaHyDRzKpAFqYBh_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x02000331 RID: 817
		[OriginalName("Rewired_Core.dll", "", "vdLqCHUeLIhADCaHyDRzKpAFqYBh")]
		public enum vdLqCHUeLIhADCaHyDRzKpAFqYBh
		{
			// Token: 0x040038C7 RID: 14535
			qZwCpXyVjNEjoeDGGdNVTisrDxS,
			// Token: 0x040038C8 RID: 14536
			qFEDTCcMtArhcpmqYJwgDzRilqFF
		}
	}
}
