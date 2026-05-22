using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000039 RID: 57
	public sealed class StringOptions : ValueType
	{
		// Token: 0x0600038E RID: 910 RVA: 0x00017E28 File Offset: 0x00016028
		// Note: this type is marked as 'beforefieldinit'.
		static StringOptions()
		{
			Il2CppClassPointerStore<StringOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "StringOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringOptions>.NativeClassPtr);
			StringOptions.NativeFieldInfoPtr_richTextEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "richTextEnabled");
			StringOptions.NativeFieldInfoPtr_scrambleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "scrambleMode");
			StringOptions.NativeFieldInfoPtr_scrambledChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "scrambledChars");
			StringOptions.NativeFieldInfoPtr_startValueStrippedLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "startValueStrippedLength");
			StringOptions.NativeFieldInfoPtr_changeValueStrippedLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "changeValueStrippedLength");
			StringOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, 100664098);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00017ED0 File Offset: 0x000160D0
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00003025 File Offset: 0x00001225
		public StringOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000302E File Offset: 0x0000122E
		public StringOptions()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOptions>.NativeClassPtr))
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00017F08 File Offset: 0x00016108
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003040 File Offset: 0x00001240
		public unsafe bool richTextEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_richTextEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_richTextEnabled)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00017F30 File Offset: 0x00016130
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0000305B File Offset: 0x0000125B
		public unsafe ScrambleMode scrambleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambleMode)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00017F58 File Offset: 0x00016158
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00003076 File Offset: 0x00001276
		public unsafe Il2CppStructArray<char> scrambledChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambledChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambledChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00017F88 File Offset: 0x00016188
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00003095 File Offset: 0x00001295
		public unsafe int startValueStrippedLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_startValueStrippedLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_startValueStrippedLength)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00017FB0 File Offset: 0x000161B0
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000030B0 File Offset: 0x000012B0
		public unsafe int changeValueStrippedLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_changeValueStrippedLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_changeValueStrippedLength)) = value;
			}
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_richTextEnabled;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_scrambleMode;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_scrambledChars;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_startValueStrippedLength;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_changeValueStrippedLength;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
