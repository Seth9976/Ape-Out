using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000CB RID: 203
	public sealed class HelpURLAttribute : Attribute
	{
		// Token: 0x0600125A RID: 4698 RVA: 0x0004AD18 File Offset: 0x00048F18
		// Note: this type is marked as 'beforefieldinit'.
		static HelpURLAttribute()
		{
			Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HelpURLAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr);
			HelpURLAttribute.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Url");
			HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Dispatcher");
			HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_DispatchingFieldName");
			HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100664831);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0004AD98 File Offset: 0x00048F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494098, XrefRangeEnd = 494100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpURLAttribute(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		public HelpURLAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0000A9E1 File Offset: 0x00008BE1
		public unsafe string m_Url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x0004AE0C File Offset: 0x0004900C
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x0000AA00 File Offset: 0x00008C00
		public unsafe bool m_Dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher)) = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x0004AE34 File Offset: 0x00049034
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x0000AA1B File Offset: 0x00008C1B
		public unsafe string m_DispatchingFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0000AA3A File Offset: 0x00008C3A
		public string URL
		{
			get
			{
				return this.m_Url;
			}
		}

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_m_Url;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatcher;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchingFieldName;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
