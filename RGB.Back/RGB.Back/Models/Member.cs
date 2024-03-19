﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RGB.Back.Models;

public partial class Member
{
    public int Id { get; set; }

    public string Account { get; set; }

    public string Password { get; set; }

    public string Mail { get; set; }

    public string AvatarUrl { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? BanTime { get; set; }

    public int Bonus { get; set; }

    public DateTime LastLoginDate { get; set; }

    public DateTime? Birthday { get; set; }

    public string NickName { get; set; }

    public bool? IsConfirmed { get; set; }

    public string ConfirmCode { get; set; }

    public string Google { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<AttachedComment> AttachedComments { get; set; } = new List<AttachedComment>();

    public virtual ICollection<BanGame> BanGames { get; set; } = new List<BanGame>();

    public virtual ICollection<BanMember> BanMemberMember1s { get; set; } = new List<BanMember>();

    public virtual ICollection<BanMember> BanMemberMember2s { get; set; } = new List<BanMember>();

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();

    public virtual ICollection<BonusItem> BonusItems { get; set; } = new List<BonusItem>();

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Collection> Collections { get; set; } = new List<Collection>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Friend> FriendMember1s { get; set; } = new List<Friend>();

    public virtual ICollection<Friend> FriendMember2s { get; set; } = new List<Friend>();

    public virtual ICollection<MemberTag> MemberTags { get; set; } = new List<MemberTag>();

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

    public virtual ICollection<WishListe> WishListes { get; set; } = new List<WishListe>();
}