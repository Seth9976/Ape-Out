using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018F RID: 399
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		// Token: 0x06001BB4 RID: 7092 RVA: 0x000A19B4 File Offset: 0x0009FBB4
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyCopyrightAttribute()
		{
			Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyCopyrightAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr);
			AssemblyCopyrightAttribute.NativeFieldInfoPtr_m_copyright = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr, "m_copyright");
			AssemblyCopyrightAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr, 100668020);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000A1A0C File Offset: 0x0009FC0C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyCopyrightAttribute(string copyright)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(copyright);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyCopyrightAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00009659 File Offset: 0x00007859
		public AssemblyCopyrightAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x000A1A58 File Offset: 0x0009FC58
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00009662 File Offset: 0x00007862
		public unsafe string m_copyright
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCopyrightAttribute.NativeFieldInfoPtr_m_copyright);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCopyrightAttribute.NativeFieldInfoPtr_m_copyright), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_m_copyright;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
