using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000450 RID: 1104
	public sealed class ComCompatibleVersionAttribute : Attribute
	{
		// Token: 0x060043FC RID: 17404 RVA: 0x00139B98 File Offset: 0x00137D98
		// Note: this type is marked as 'beforefieldinit'.
		static ComCompatibleVersionAttribute()
		{
			Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComCompatibleVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr);
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_major");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_minor");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_build");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_revision");
			ComCompatibleVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, 100673189);
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00139C2C File Offset: 0x00137E2C
		[CallerCount(0)]
		public unsafe ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref revision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComCompatibleVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00019EED File Offset: 0x000180ED
		public ComCompatibleVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x00139CA0 File Offset: 0x00137EA0
		// (set) Token: 0x06004400 RID: 17408 RVA: 0x00019EF6 File Offset: 0x000180F6
		public unsafe int _major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__major)) = value;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x00139CC8 File Offset: 0x00137EC8
		// (set) Token: 0x06004402 RID: 17410 RVA: 0x00019F11 File Offset: 0x00018111
		public unsafe int _minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor)) = value;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x00139CF0 File Offset: 0x00137EF0
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x00019F2C File Offset: 0x0001812C
		public unsafe int _build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__build)) = value;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x00139D18 File Offset: 0x00137F18
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x00019F47 File Offset: 0x00018147
		public unsafe int _revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision)) = value;
			}
		}

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeFieldInfoPtr__major;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeFieldInfoPtr__minor;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeFieldInfoPtr__build;

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr__revision;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
	}
}
