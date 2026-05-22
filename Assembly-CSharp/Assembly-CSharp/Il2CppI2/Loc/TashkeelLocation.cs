using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000267 RID: 615
	public class TashkeelLocation : Object
	{
		// Token: 0x06004657 RID: 18007 RVA: 0x00106750 File Offset: 0x00104950
		// Note: this type is marked as 'beforefieldinit'.
		static TashkeelLocation()
		{
			Il2CppClassPointerStore<TashkeelLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TashkeelLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TashkeelLocation>.NativeClassPtr);
			TashkeelLocation.NativeFieldInfoPtr_tashkeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TashkeelLocation>.NativeClassPtr, "tashkeel");
			TashkeelLocation.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TashkeelLocation>.NativeClassPtr, "position");
			TashkeelLocation.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TashkeelLocation>.NativeClassPtr, 100670411);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001067BC File Offset: 0x001049BC
		[CallerCount(0)]
		public unsafe TashkeelLocation(char tashkeel, int position)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TashkeelLocation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tashkeel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TashkeelLocation.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00029DDB File Offset: 0x00027FDB
		public TashkeelLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x00106814 File Offset: 0x00104A14
		// (set) Token: 0x0600465B RID: 18011 RVA: 0x00029DE4 File Offset: 0x00027FE4
		public unsafe char tashkeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TashkeelLocation.NativeFieldInfoPtr_tashkeel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TashkeelLocation.NativeFieldInfoPtr_tashkeel)) = value;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x0010683C File Offset: 0x00104A3C
		// (set) Token: 0x0600465D RID: 18013 RVA: 0x00029DFF File Offset: 0x00027FFF
		public unsafe int position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TashkeelLocation.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TashkeelLocation.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeFieldInfoPtr_tashkeel;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0;
	}
}
