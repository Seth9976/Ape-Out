using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200012D RID: 301
	public class UnityUnifiedKeyboardSource : Object
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x000A2978 File Offset: 0x000A0B78
		// Note: this type is marked as 'beforefieldinit'.
		static UnityUnifiedKeyboardSource()
		{
			Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "UnityUnifiedKeyboardSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr);
			UnityUnifiedKeyboardSource.NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, "MXvdFwIPBexhyMATfJEjXZJJhWG");
			UnityUnifiedKeyboardSource.NativeFieldInfoPtr_JxcKHiBkjhlhxqIgQQhxrWydAVv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, "JxcKHiBkjhlhxqIgQQhxrWydAVv");
			UnityUnifiedKeyboardSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_inputSource_Public_Virtual_Final_New_get_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670042);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_hardwareMap_Public_Virtual_Final_New_get_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670043);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670044);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_controllerExtension_Public_Virtual_Final_New_get_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670045);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670046);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_UpdateInputData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670047);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670048);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_FXJslePCfScWXPBsXdIsNfRqHUH_Private_Static_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670049);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670050);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670051);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670052);
			UnityUnifiedKeyboardSource.NativeMethodInfoPtr_GetHardwareElementType_Public_Static_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr, 100670053);
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x000A2AD4 File Offset: 0x000A0CD4
		public unsafe virtual InputSource inputSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_inputSource_Public_Virtual_Final_New_get_InputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000A2B10 File Offset: 0x000A0D10
		public unsafe virtual HardwareControllerMap_Game hardwareMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282268, XrefRangeEnd = 282273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_hardwareMap_Public_Virtual_Final_New_get_HardwareControllerMap_Game_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr3) : null;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x000A2B50 File Offset: 0x000A0D50
		public unsafe virtual int buttonCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000A2B8C File Offset: 0x000A0D8C
		public unsafe virtual Controller.Extension controllerExtension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_get_controllerExtension_Public_Virtual_Final_New_get_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000A2BCC File Offset: 0x000A0DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282273, XrefRangeEnd = 282274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityUnifiedKeyboardSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUnifiedKeyboardSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x000A2C08 File Offset: 0x000A0E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282274, XrefRangeEnd = 282278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_UpdateInputData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000A2C4C File Offset: 0x000A0E4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000A2C80 File Offset: 0x000A0E80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282330, RefRangeEnd = 282332, XrefRangeStart = 282278, XrefRangeEnd = 282330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HardwareControllerMap_Game FXJslePCfScWXPBsXdIsNfRqHUH()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_FXJslePCfScWXPBsXdIsNfRqHUH_Private_Static_HardwareControllerMap_Game_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr3) : null;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000A2CB4 File Offset: 0x000A0EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282332, XrefRangeEnd = 282336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x000A2CE8 File Offset: 0x000A0EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282336, XrefRangeEnd = 282337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000A2D24 File Offset: 0x000A0F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282337, XrefRangeEnd = 282342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityUnifiedKeyboardSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000A2D70 File Offset: 0x000A0F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282342, XrefRangeEnd = 282349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerElementType GetHardwareElementType(int elementIdentifierId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityUnifiedKeyboardSource.NativeMethodInfoPtr_GetHardwareElementType_Public_Static_ControllerElementType_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		public UnityUnifiedKeyboardSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x000A2DB0 File Offset: 0x000A0FB0
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x0000CB93 File Offset: 0x0000AD93
		public unsafe static int MXvdFwIPBexhyMATfJEjXZJJhWG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnityUnifiedKeyboardSource.NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityUnifiedKeyboardSource.NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG, (void*)(&value));
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x000A2DCC File Offset: 0x000A0FCC
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x0000CBA1 File Offset: 0x0000ADA1
		public unsafe static HardwareControllerMap_Game JxcKHiBkjhlhxqIgQQhxrWydAVv
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityUnifiedKeyboardSource.NativeFieldInfoPtr_JxcKHiBkjhlhxqIgQQhxrWydAVv, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityUnifiedKeyboardSource.NativeFieldInfoPtr_JxcKHiBkjhlhxqIgQQhxrWydAVv, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x000A2DF4 File Offset: 0x000A0FF4
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x0000CBB3 File Offset: 0x0000ADB3
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUnifiedKeyboardSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityUnifiedKeyboardSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_JxcKHiBkjhlhxqIgQQhxrWydAVv;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSource_Public_Virtual_Final_New_get_InputSource_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareMap_Public_Virtual_Final_New_get_HardwareControllerMap_Game_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerExtension_Public_Virtual_Final_New_get_Extension_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputData_Public_Virtual_Final_New_Void_ControllerDataUpdater_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_FXJslePCfScWXPBsXdIsNfRqHUH_Private_Static_HardwareControllerMap_Game_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_GetHardwareElementType_Public_Static_ControllerElementType_Int32_0;
	}
}
