using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200010C RID: 268
	public class Score : Object
	{
		// Token: 0x06002025 RID: 8229 RVA: 0x0008E530 File Offset: 0x0008C730
		// Note: this type is marked as 'beforefieldinit'.
		static Score()
		{
			Il2CppClassPointerStore<Score>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Score");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Score>.NativeClassPtr);
			Score.NativeFieldInfoPtr_initials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Score>.NativeClassPtr, "initials");
			Score.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Score>.NativeClassPtr, "score");
			Score.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Score>.NativeClassPtr, "distance");
			Score.NativeFieldInfoPtr_kills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Score>.NativeClassPtr, "kills");
			Score.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Score>.NativeClassPtr, 100665840);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0008E5C4 File Offset: 0x0008C7C4
		[CallerCount(0)]
		public unsafe Score(string init, int scor, float dist, int kill)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Score>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(init);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dist;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Score.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000167B8 File Offset: 0x000149B8
		public Score(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x0008E63C File Offset: 0x0008C83C
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x000167C1 File Offset: 0x000149C1
		public unsafe string initials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_initials);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_initials), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0008E664 File Offset: 0x0008C864
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x000167E0 File Offset: 0x000149E0
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x0008E68C File Offset: 0x0008C88C
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x000167FB File Offset: 0x000149FB
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x0008E6B4 File Offset: 0x0008C8B4
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00016816 File Offset: 0x00014A16
		public unsafe int kills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_kills);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Score.NativeFieldInfoPtr_kills)) = value;
			}
		}

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_initials;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_kills;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_Int32_0;
	}
}
