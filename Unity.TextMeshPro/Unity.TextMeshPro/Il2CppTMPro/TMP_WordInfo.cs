using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000068 RID: 104
	public sealed class TMP_WordInfo : ValueType
	{
		// Token: 0x06000C66 RID: 3174 RVA: 0x00034478 File Offset: 0x00032678
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_WordInfo()
		{
			Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_WordInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr);
			TMP_WordInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "textComponent");
			TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_WordInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, "characterCount");
			TMP_WordInfo.NativeMethodInfoPtr_GetWord_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr, 100664709);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003450C File Offset: 0x0003270C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464509, XrefRangeEnd = 464527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetWord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_WordInfo.NativeMethodInfoPtr_GetWord_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00007BD1 File Offset: 0x00005DD1
		public TMP_WordInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00007BDA File Offset: 0x00005DDA
		public TMP_WordInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_WordInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00034548 File Offset: 0x00032748
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00007BEC File Offset: 0x00005DEC
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00034578 File Offset: 0x00032778
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00007C0B File Offset: 0x00005E0B
		public unsafe int firstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_firstCharacterIndex)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000345A0 File Offset: 0x000327A0
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00007C26 File Offset: 0x00005E26
		public unsafe int lastCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_lastCharacterIndex)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000345C8 File Offset: 0x000327C8
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00007C41 File Offset: 0x00005E41
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_WordInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_GetWord_Public_String_0;
	}
}
