using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000231 RID: 561
	public sealed class TranslationQuery : ValueType
	{
		// Token: 0x060042E7 RID: 17127 RVA: 0x000F8F74 File Offset: 0x000F7174
		// Note: this type is marked as 'beforefieldinit'.
		static TranslationQuery()
		{
			Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "TranslationQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr);
			TranslationQuery.NativeFieldInfoPtr_OrigText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr, "OrigText");
			TranslationQuery.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr, "Text");
			TranslationQuery.NativeFieldInfoPtr_LanguageCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr, "LanguageCode");
			TranslationQuery.NativeFieldInfoPtr_TargetLanguagesCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr, "TargetLanguagesCode");
			TranslationQuery.NativeFieldInfoPtr_Results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr, "Results");
			TranslationQuery.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr, "Tags");
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000289A4 File Offset: 0x00026BA4
		public TranslationQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x000289AD File Offset: 0x00026BAD
		public TranslationQuery()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranslationQuery>.NativeClassPtr))
		{
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x000F901C File Offset: 0x000F721C
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x000289BF File Offset: 0x00026BBF
		public unsafe string OrigText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_OrigText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_OrigText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x000F9044 File Offset: 0x000F7244
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x000289DE File Offset: 0x00026BDE
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x000F906C File Offset: 0x000F726C
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x000289FD File Offset: 0x00026BFD
		public unsafe string LanguageCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_LanguageCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_LanguageCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x000F9094 File Offset: 0x000F7294
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00028A1C File Offset: 0x00026C1C
		public unsafe Il2CppStringArray TargetLanguagesCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_TargetLanguagesCode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_TargetLanguagesCode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x000F90C4 File Offset: 0x000F72C4
		// (set) Token: 0x060042F3 RID: 17139 RVA: 0x00028A3B File Offset: 0x00026C3B
		public unsafe Il2CppStringArray Results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_Results);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_Results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x000F90F4 File Offset: 0x000F72F4
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00028A5A File Offset: 0x00026C5A
		public unsafe Il2CppStringArray Tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_Tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranslationQuery.NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeFieldInfoPtr_OrigText;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeFieldInfoPtr_LanguageCode;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeFieldInfoPtr_TargetLanguagesCode;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeFieldInfoPtr_Results;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeFieldInfoPtr_Tags;
	}
}
