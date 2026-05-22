using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000169 RID: 361
	[Serializable]
	public class EncoderFallback : Object
	{
		// Token: 0x06001883 RID: 6275 RVA: 0x00092A08 File Offset: 0x00090C08
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallback()
		{
			Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr);
			EncoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "bIsMicrosoftBestFitFallback");
			EncoderFallback.NativeFieldInfoPtr_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "replacementFallback");
			EncoderFallback.NativeFieldInfoPtr_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "exceptionFallback");
			EncoderFallback.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "s_InternalSyncObject");
			EncoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667430);
			EncoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667431);
			EncoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667432);
			EncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667433);
			EncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667434);
			EncoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100667435);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00092B00 File Offset: 0x00090D00
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 179722, RefRangeEnd = 179724, XrefRangeStart = 179715, XrefRangeEnd = 179722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00092B34 File Offset: 0x00090D34
		public unsafe static EncoderFallback ReplacementFallback
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 179739, RefRangeEnd = 179744, XrefRangeStart = 179724, XrefRangeEnd = 179739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00092B68 File Offset: 0x00090D68
		public unsafe static EncoderFallback ExceptionFallback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 179756, RefRangeEnd = 179759, XrefRangeStart = 179744, XrefRangeEnd = 179756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00092B9C File Offset: 0x00090D9C
		[CallerCount(0)]
		public unsafe virtual EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00092BE8 File Offset: 0x00090DE8
		public unsafe virtual int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00092C30 File Offset: 0x00090E30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00008797 File Offset: 0x00006997
		public EncoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00092C6C File Offset: 0x00090E6C
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x000087A0 File Offset: 0x000069A0
		public unsafe bool bIsMicrosoftBestFitFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00092C94 File Offset: 0x00090E94
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x000087BB File Offset: 0x000069BB
		public unsafe static EncoderFallback replacementFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_replacementFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_replacementFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00092CBC File Offset: 0x00090EBC
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x000087CD File Offset: 0x000069CD
		public unsafe static EncoderFallback exceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_exceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_exceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x00092CE4 File Offset: 0x00090EE4
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x000087DF File Offset: 0x000069DF
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_bIsMicrosoftBestFitFallback;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_replacementFallback;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr_exceptionFallback;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
