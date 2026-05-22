using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004D RID: 77
	public class AbstractEventData : Object
	{
		// Token: 0x060008C6 RID: 2246 RVA: 0x000291D4 File Offset: 0x000273D4
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractEventData()
		{
			Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AbstractEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr);
			AbstractEventData.NativeFieldInfoPtr_m_Used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, "m_Used");
			AbstractEventData.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664715);
			AbstractEventData.NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664716);
			AbstractEventData.NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664717);
			AbstractEventData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664718);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00029268 File Offset: 0x00027468
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000292A4 File Offset: 0x000274A4
		[CallerCount(0)]
		public unsafe virtual void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x000292E0 File Offset: 0x000274E0
		public unsafe virtual bool used
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00029328 File Offset: 0x00027528
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractEventData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractEventData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00005086 File Offset: 0x00003286
		public AbstractEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00029364 File Offset: 0x00027564
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0000508F File Offset: 0x0000328F
		public unsafe bool m_Used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractEventData.NativeFieldInfoPtr_m_Used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractEventData.NativeFieldInfoPtr_m_Used)) = value;
			}
		}

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_m_Used;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
