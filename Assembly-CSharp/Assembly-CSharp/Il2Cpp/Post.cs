using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000169 RID: 361
	public class Post : MonoBehaviour
	{
		// Token: 0x06002BAA RID: 11178 RVA: 0x000AD0A0 File Offset: 0x000AB2A0
		// Note: this type is marked as 'beforefieldinit'.
		static Post()
		{
			Il2CppClassPointerStore<Post>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Post");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Post>.NativeClassPtr);
			Post.NativeFieldInfoPtr_connectedPost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Post>.NativeClassPtr, "connectedPost");
			Post.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Post>.NativeClassPtr, "lines");
			Post.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Post>.NativeClassPtr, "top");
			Post.NativeFieldInfoPtr_bot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Post>.NativeClassPtr, "bot");
			Post.NativeFieldInfoPtr_rock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Post>.NativeClassPtr, "rock");
			Post.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Post>.NativeClassPtr, 100666729);
			Post.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Post>.NativeClassPtr, 100666730);
			Post.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Post>.NativeClassPtr, 100666731);
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x000AD170 File Offset: 0x000AB370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79555, XrefRangeEnd = 79620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Post.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000AD1A4 File Offset: 0x000AB3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79620, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Post.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000AD1D8 File Offset: 0x000AB3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Post()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Post>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Post.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x0001E460 File Offset: 0x0001C660
		public Post(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000AD214 File Offset: 0x000AB414
		// (set) Token: 0x06002BB0 RID: 11184 RVA: 0x0001E469 File Offset: 0x0001C669
		public unsafe Post connectedPost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_connectedPost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Post>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_connectedPost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000AD244 File Offset: 0x000AB444
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x0001E488 File Offset: 0x0001C688
		public unsafe Il2CppReferenceArray<LineRenderer> lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LineRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x000AD274 File Offset: 0x000AB474
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x0001E4A7 File Offset: 0x0001C6A7
		public unsafe Transform top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_top);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_top), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x000AD2A4 File Offset: 0x000AB4A4
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x0001E4C6 File Offset: 0x0001C6C6
		public unsafe Transform bot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_bot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_bot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x000AD2D4 File Offset: 0x000AB4D4
		// (set) Token: 0x06002BB8 RID: 11192 RVA: 0x0001E4E5 File Offset: 0x0001C6E5
		public unsafe RockTech rock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_rock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Post.NativeFieldInfoPtr_rock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeFieldInfoPtr_connectedPost;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeFieldInfoPtr_lines;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_bot;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_rock;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
