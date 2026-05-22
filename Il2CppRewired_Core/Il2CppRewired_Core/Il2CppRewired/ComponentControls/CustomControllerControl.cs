using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ComponentControls.Data;
using Il2CppSystem;

namespace Il2CppRewired.ComponentControls
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class CustomControllerControl : ComponentControl
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x000405FC File Offset: 0x0003E7FC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerControl()
		{
			Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls", "CustomControllerControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr);
			CustomControllerControl.NativeMethodInfoPtr_get_controller_Internal_get_CustomController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664138);
			CustomControllerControl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664139);
			CustomControllerControl.NativeMethodInfoPtr_get_hasController_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664140);
			CustomControllerControl.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664141);
			CustomControllerControl.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664142);
			CustomControllerControl.NativeMethodInfoPtr_FindController_Internal_Virtual_IComponentController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664143);
			CustomControllerControl.NativeMethodInfoPtr_GetRequiredControllerType_Internal_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664144);
			CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Internal_Void_CustomControllerElementTargetSet_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664145);
			CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Internal_Void_CustomControllerElementTargetSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664146);
			CustomControllerControl.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664147);
			CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Private_Void_CustomControllerElementTarget_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664148);
			CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Private_Void_CustomControllerElementTarget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664149);
			CustomControllerControl.NativeMethodInfoPtr_wxfCBnsXJFrchrVOIgWqRoWcRNo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr, 100664150);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00040730 File Offset: 0x0003E930
		public unsafe CustomController controller
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 245760, RefRangeEnd = 245786, XrefRangeStart = 245759, XrefRangeEnd = 245760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr_get_controller_Internal_get_CustomController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr3) : null;
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00040770 File Offset: 0x0003E970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000407AC File Offset: 0x0003E9AC
		public unsafe override bool hasController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245786, XrefRangeEnd = 245802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerControl.NativeMethodInfoPtr_get_hasController_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000407F4 File Offset: 0x0003E9F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245812, RefRangeEnd = 245814, XrefRangeStart = 245802, XrefRangeEnd = 245812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ilLZkNyFIEwkNbOyQNmFFIpMaQo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerControl.NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00040830 File Offset: 0x0003EA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245824, RefRangeEnd = 245826, XrefRangeStart = 245814, XrefRangeEnd = 245824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LCmYrwVZzAfLeUiFDvNHaNMWskx()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerControl.NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0004086C File Offset: 0x0003EA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245826, XrefRangeEnd = 245836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IComponentController FindController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerControl.NativeMethodInfoPtr_FindController_Internal_Virtual_IComponentController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponentController>(intPtr3) : null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000408B8 File Offset: 0x0003EAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245836, XrefRangeEnd = 245842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetRequiredControllerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerControl.NativeMethodInfoPtr_GetRequiredControllerType_Internal_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00040904 File Offset: 0x0003EB04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 245850, RefRangeEnd = 245857, XrefRangeStart = 245842, XrefRangeEnd = 245850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SNOCoomtEzmbpJDtfogfJZrKSnS(CustomControllerElementTargetSet A_1, float A_2, float A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Internal_Void_CustomControllerElementTargetSet_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00040964 File Offset: 0x0003EB64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245865, RefRangeEnd = 245868, XrefRangeStart = 245857, XrefRangeEnd = 245865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SNOCoomtEzmbpJDtfogfJZrKSnS(CustomControllerElementTargetSet A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Internal_Void_CustomControllerElementTargetSet_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000409B4 File Offset: 0x0003EBB4
		[CallerCount(0)]
		public unsafe virtual void zKEQtrzzyQhnNzFWJQGLGZUsGJG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomControllerControl.NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000409F0 File Offset: 0x0003EBF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245873, RefRangeEnd = 245875, XrefRangeStart = 245868, XrefRangeEnd = 245873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SNOCoomtEzmbpJDtfogfJZrKSnS(CustomControllerElementTarget A_1, float A_2, float A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Private_Void_CustomControllerElementTarget_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00040A50 File Offset: 0x0003EC50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245877, RefRangeEnd = 245879, XrefRangeStart = 245875, XrefRangeEnd = 245877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SNOCoomtEzmbpJDtfogfJZrKSnS(CustomControllerElementTarget A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Private_Void_CustomControllerElementTarget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00040AA0 File Offset: 0x0003ECA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245879, XrefRangeEnd = 245884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void wxfCBnsXJFrchrVOIgWqRoWcRNo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerControl.NativeMethodInfoPtr_wxfCBnsXJFrchrVOIgWqRoWcRNo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000386D File Offset: 0x00001A6D
		public CustomControllerControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Internal_get_CustomController_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_get_hasController_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_ilLZkNyFIEwkNbOyQNmFFIpMaQo_Internal_Virtual_Void_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_LCmYrwVZzAfLeUiFDvNHaNMWskx_Internal_Virtual_Void_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_FindController_Internal_Virtual_IComponentController_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredControllerType_Internal_Virtual_Type_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Internal_Void_CustomControllerElementTargetSet_Single_Single_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Internal_Void_CustomControllerElementTargetSet_Boolean_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_zKEQtrzzyQhnNzFWJQGLGZUsGJG_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Private_Void_CustomControllerElementTarget_Single_Single_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_SNOCoomtEzmbpJDtfogfJZrKSnS_Private_Void_CustomControllerElementTarget_Boolean_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_wxfCBnsXJFrchrVOIgWqRoWcRNo_Private_Void_0;
	}
}
