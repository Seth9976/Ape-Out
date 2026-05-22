using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000265 RID: 613
	public class ArabicMapping : Object
	{
		// Token: 0x06004647 RID: 17991 RVA: 0x0010649C File Offset: 0x0010469C
		// Note: this type is marked as 'beforefieldinit'.
		static ArabicMapping()
		{
			Il2CppClassPointerStore<ArabicMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ArabicMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArabicMapping>.NativeClassPtr);
			ArabicMapping.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArabicMapping>.NativeClassPtr, "from");
			ArabicMapping.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArabicMapping>.NativeClassPtr, "to");
			ArabicMapping.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArabicMapping>.NativeClassPtr, 100670407);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00106508 File Offset: 0x00104708
		[CallerCount(0)]
		public unsafe ArabicMapping(int from, int to)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArabicMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArabicMapping.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00029D6F File Offset: 0x00027F6F
		public ArabicMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x00106560 File Offset: 0x00104760
		// (set) Token: 0x0600464B RID: 17995 RVA: 0x00029D78 File Offset: 0x00027F78
		public unsafe int from
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArabicMapping.NativeFieldInfoPtr_from);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArabicMapping.NativeFieldInfoPtr_from)) = value;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x00106588 File Offset: 0x00104788
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x00029D93 File Offset: 0x00027F93
		public unsafe int to
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArabicMapping.NativeFieldInfoPtr_to);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArabicMapping.NativeFieldInfoPtr_to)) = value;
			}
		}

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeFieldInfoPtr_from;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeFieldInfoPtr_to;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
