using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x0200000A RID: 10
	public class UploadHandler : Object
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00006068 File Offset: 0x00004268
		// Note: this type is marked as 'beforefieldinit'.
		static UploadHandler()
		{
			Il2CppClassPointerStore<UploadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UploadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr);
			UploadHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, "m_Ptr");
			UploadHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663386);
			UploadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663387);
			UploadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663388);
			UploadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663389);
			UploadHandler.InternalGetContentTypeDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalGetContentTypeDelegate>("UnityEngine.Networking.UploadHandler::InternalGetContentType");
			UploadHandler.InternalSetContentTypeDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalSetContentTypeDelegate>("UnityEngine.Networking.UploadHandler::InternalSetContentType");
			UploadHandler.InternalGetProgressDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalGetProgressDelegate>("UnityEngine.Networking.UploadHandler::InternalGetProgress");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000612C File Offset: 0x0000432C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534880, XrefRangeEnd = 534884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006160 File Offset: 0x00004360
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000619C File Offset: 0x0000439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534884, XrefRangeEnd = 534886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000061D8 File Offset: 0x000043D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534889, RefRangeEnd = 534891, XrefRangeStart = 534886, XrefRangeEnd = 534889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000254D File Offset: 0x0000074D
		public UploadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000620C File Offset: 0x0000440C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00006234 File Offset: 0x00004434
		public Il2CppStructArray<byte> data
		{
			get
			{
				return this.GetData();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000624C File Offset: 0x0000444C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002571 File Offset: 0x00000771
		public string contentType
		{
			get
			{
				return this.GetContentType();
			}
			set
			{
				this.SetContentType(value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006264 File Offset: 0x00004464
		public float progress
		{
			get
			{
				return this.GetProgress();
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000627C File Offset: 0x0000447C
		public virtual Il2CppStructArray<byte> GetData()
		{
			return null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006290 File Offset: 0x00004490
		public virtual string GetContentType()
		{
			return this.InternalGetContentType();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000257C File Offset: 0x0000077C
		public virtual void SetContentType(string newContentType)
		{
			this.InternalSetContentType(newContentType);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000062A8 File Offset: 0x000044A8
		public virtual float GetProgress()
		{
			return this.InternalGetProgress();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000062C0 File Offset: 0x000044C0
		public string InternalGetContentType()
		{
			IntPtr intPtr = UploadHandler.InternalGetContentTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002587 File Offset: 0x00000787
		public void InternalSetContentType(string newContentType)
		{
			UploadHandler.InternalSetContentTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(newContentType));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000259F File Offset: 0x0000079F
		public float InternalGetProgress()
		{
			return UploadHandler.InternalGetProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000099 RID: 153
		private static readonly UploadHandler.InternalGetContentTypeDelegate InternalGetContentTypeDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly UploadHandler.InternalSetContentTypeDelegate InternalSetContentTypeDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly UploadHandler.InternalGetProgressDelegate InternalGetProgressDelegateField;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate IntPtr InternalGetContentTypeDelegate(IntPtr @this);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void InternalSetContentTypeDelegate(IntPtr @this, IntPtr newContentType);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate float InternalGetProgressDelegate(IntPtr @this);
	}
}
