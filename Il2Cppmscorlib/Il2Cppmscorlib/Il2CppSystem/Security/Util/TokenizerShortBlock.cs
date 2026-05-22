using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002CA RID: 714
	public sealed class TokenizerShortBlock : Object
	{
		// Token: 0x06003080 RID: 12416 RVA: 0x000F543C File Offset: 0x000F363C
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerShortBlock()
		{
			Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerShortBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr);
			TokenizerShortBlock.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, "m_block");
			TokenizerShortBlock.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, "m_next");
			TokenizerShortBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, 100671017);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x000F54A8 File Offset: 0x000F36A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208355, RefRangeEnd = 208358, XrefRangeStart = 208352, XrefRangeEnd = 208355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerShortBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerShortBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00010D18 File Offset: 0x0000EF18
		public TokenizerShortBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x000F54E4 File Offset: 0x000F36E4
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x00010D21 File Offset: 0x0000EF21
		public unsafe Il2CppStructArray<short> m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x000F5514 File Offset: 0x000F3714
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x00010D40 File Offset: 0x0000EF40
		public unsafe TokenizerShortBlock m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
