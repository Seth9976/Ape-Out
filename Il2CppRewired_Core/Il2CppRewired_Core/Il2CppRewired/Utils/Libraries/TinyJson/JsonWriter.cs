using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppRewired.Utils.Libraries.TinyJson
{
	// Token: 0x020001DE RID: 478
	public static class JsonWriter : Object
	{
		// Token: 0x0600310A RID: 12554 RVA: 0x000F3B34 File Offset: 0x000F1D34
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWriter()
		{
			Il2CppClassPointerStore<JsonWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Libraries.TinyJson", "JsonWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr);
			JsonWriter.NativeFieldInfoPtr_hMzBmTpprYdYsDDSNXpTmguAOpEh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "hMzBmTpprYdYsDDSNXpTmguAOpEh");
			JsonWriter.NativeMethodInfoPtr_get_appendValueDelegate_Private_Static_get_Action_2_StringBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100675768);
			JsonWriter.NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100675769);
			JsonWriter.NativeMethodInfoPtr_CQyWqveFmJIIGPYxdGmTZcHMXTV_Private_Static_Void_StringBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100675770);
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000F3BB4 File Offset: 0x000F1DB4
		public unsafe static Action<StringBuilder, Object> appendValueDelegate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336508, XrefRangeEnd = 336517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_appendValueDelegate_Private_Static_get_Action_2_StringBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<StringBuilder, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000F3BE8 File Offset: 0x000F1DE8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 336526, RefRangeEnd = 336556, XrefRangeStart = 336517, XrefRangeEnd = 336526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson(Object item)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x000F3C24 File Offset: 0x000F1E24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 336846, RefRangeEnd = 336851, XrefRangeStart = 336556, XrefRangeEnd = 336846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CQyWqveFmJIIGPYxdGmTZcHMXTV(StringBuilder A_0, Object A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_CQyWqveFmJIIGPYxdGmTZcHMXTV_Private_Static_Void_StringBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00011A21 File Offset: 0x0000FC21
		public JsonWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x000F3C6C File Offset: 0x000F1E6C
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x00011A2A File Offset: 0x0000FC2A
		public unsafe static Action<StringBuilder, Object> hMzBmTpprYdYsDDSNXpTmguAOpEh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonWriter.NativeFieldInfoPtr_hMzBmTpprYdYsDDSNXpTmguAOpEh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StringBuilder, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonWriter.NativeFieldInfoPtr_hMzBmTpprYdYsDDSNXpTmguAOpEh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeFieldInfoPtr_hMzBmTpprYdYsDDSNXpTmguAOpEh;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeMethodInfoPtr_get_appendValueDelegate_Private_Static_get_Action_2_StringBuilder_Object_0;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeMethodInfoPtr_CQyWqveFmJIIGPYxdGmTZcHMXTV_Private_Static_Void_StringBuilder_Object_0;
	}
}
