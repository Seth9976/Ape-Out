using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Internal
{
	// Token: 0x02000128 RID: 296
	public class OnGUIHelper : MonoBehaviour
	{
		// Token: 0x06001E72 RID: 7794 RVA: 0x0009FC68 File Offset: 0x0009DE68
		// Note: this type is marked as 'beforefieldinit'.
		static OnGUIHelper()
		{
			Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Internal", "OnGUIHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr);
			OnGUIHelper.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr, "QOvYBMumHBTKRswPnUjkbLxwisx");
			OnGUIHelper.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr, 100669903);
			OnGUIHelper.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr, 100669904);
			OnGUIHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr, 100669905);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0009FCE8 File Offset: 0x0009DEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281506, XrefRangeEnd = 281509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnGUIHelper.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0009FD1C File Offset: 0x0009DF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281509, XrefRangeEnd = 281527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnGUIHelper.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0009FD50 File Offset: 0x0009DF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnGUIHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnGUIHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnGUIHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0000C90E File Offset: 0x0000AB0E
		public OnGUIHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0009FD8C File Offset: 0x0009DF8C
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0000C917 File Offset: 0x0000AB17
		public unsafe InputManager_Base QOvYBMumHBTKRswPnUjkbLxwisx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnGUIHelper.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputManager_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnGUIHelper.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
