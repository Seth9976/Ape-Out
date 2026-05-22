using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics.Hashing
{
	// Token: 0x02000258 RID: 600
	public static class HashHelpers : Object
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x000DC420 File Offset: 0x000DA620
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics.Hashing", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "RandomSeed");
			HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100670076);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000DC478 File Offset: 0x000DA678
		[CallerCount(0)]
		public unsafe static int Combine(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000DC4C4 File Offset: 0x000DA6C4
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0000E705 File Offset: 0x0000C905
		public unsafe static int RandomSeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_RandomSeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_RandomSeed, (void*)(&value));
			}
		}

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeFieldInfoPtr_RandomSeed;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;
	}
}
