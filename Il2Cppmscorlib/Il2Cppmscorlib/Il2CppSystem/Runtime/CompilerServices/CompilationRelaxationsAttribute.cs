using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042A RID: 1066
	[Serializable]
	public class CompilationRelaxationsAttribute : Attribute
	{
		// Token: 0x0600432F RID: 17199 RVA: 0x001377F8 File Offset: 0x001359F8
		// Note: this type is marked as 'beforefieldinit'.
		static CompilationRelaxationsAttribute()
		{
			Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilationRelaxationsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr);
			CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, "m_relaxations");
			CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100673125);
			CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100673126);
			CompilationRelaxationsAttribute.NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100673127);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00137878 File Offset: 0x00135A78
		[CallerCount(0)]
		public unsafe CompilationRelaxationsAttribute(int relaxations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relaxations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x001378C0 File Offset: 0x00135AC0
		[CallerCount(0)]
		public unsafe CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relaxations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x00137908 File Offset: 0x00135B08
		public unsafe int CompilationRelaxations
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilationRelaxationsAttribute.NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x00019705 File Offset: 0x00017905
		public CompilationRelaxationsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x00137944 File Offset: 0x00135B44
		// (set) Token: 0x06004335 RID: 17205 RVA: 0x0001970E File Offset: 0x0001790E
		public unsafe int m_relaxations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompilationRelaxationsAttribute.NativeFieldInfoPtr_m_relaxations)) = value;
			}
		}

		// Token: 0x040036A8 RID: 13992
		private static readonly IntPtr NativeFieldInfoPtr_m_relaxations;

		// Token: 0x040036A9 RID: 13993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040036AA RID: 13994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0;

		// Token: 0x040036AB RID: 13995
		private static readonly IntPtr NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0;
	}
}
