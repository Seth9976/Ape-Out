using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000431 RID: 1073
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		// Token: 0x06004354 RID: 17236 RVA: 0x00137E98 File Offset: 0x00136098
		// Note: this type is marked as 'beforefieldinit'.
		static InternalsVisibleToAttribute()
		{
			Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "InternalsVisibleToAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr);
			InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_assemblyName");
			InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_allInternalsVisible");
			InternalsVisibleToAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100673138);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100673139);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AllInternalsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100673140);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100673141);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00137F40 File Offset: 0x00136140
		[CallerCount(0)]
		public unsafe InternalsVisibleToAttribute(string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x00137F8C File Offset: 0x0013618C
		public unsafe string AssemblyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x00137FC4 File Offset: 0x001361C4
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x00138000 File Offset: 0x00136200
		public unsafe bool AllInternalsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AllInternalsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00019841 File Offset: 0x00017A41
		public InternalsVisibleToAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x0600435A RID: 17242 RVA: 0x00138040 File Offset: 0x00136240
		// (set) Token: 0x0600435B RID: 17243 RVA: 0x0001984A File Offset: 0x00017A4A
		public unsafe string _assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x00138068 File Offset: 0x00136268
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x00019869 File Offset: 0x00017A69
		public unsafe bool _allInternalsVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible)) = value;
			}
		}

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeFieldInfoPtr__assemblyName;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeFieldInfoPtr__allInternalsVisible;

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeMethodInfoPtr_get_AllInternalsVisible_Public_get_Boolean_0;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0;
	}
}
