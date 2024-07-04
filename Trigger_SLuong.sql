create trigger trg_sl on chitiethoadon
for insert
as
begin
	update hanghoa set hanghoa.soluong=hanghoa.soluong - (
	select SLuong from inserted
	where masp=hanghoa.masp)
	from hanghoa
	join inserted on hanghoa.masp= inserted.masp
	update hanghoa set hanghoa.daban = hanghoa.daban + (
	select SLuong from inserted
	where masp = hanghoa.masp)
	from hanghoa
	join inserted on hanghoa.masp= inserted.masp
end

create trigger trg_sl_xoa on chitiethoadon
for delete
as
begin
	update hanghoa set hanghoa.soluong=hanghoa.soluong + (
	select SLuong from deleted
	where masp=hanghoa.masp)
	from hanghoa
	join deleted on hanghoa.masp= deleted.masp
	update hanghoa set hanghoa.daban = hanghoa.daban - (
	select SLuong from deleted
	where masp = hanghoa.masp)
	from hanghoa
	join deleted on hanghoa.masp= deleted.masp
end

create trigger trg_slupdate on chitiethoadon
for update
as
if update(SLuong)
begin
	update hanghoa set hanghoa.soluong=hanghoa.soluong - (
	select SLuong from inserted
	where masp=hanghoa.masp) +(
	select SLuong from deleted
	where masp=hanghoa.masp)
	from hanghoa
	join deleted on hanghoa.masp=deleted.masp
	update hanghoa set hanghoa.daban=hanghoa.daban + (
	select SLuong from inserted
	where masp=hanghoa.masp) -(
	select SLuong from deleted
	where masp=hanghoa.masp)
	from hanghoa
	join deleted on hanghoa.masp=deleted.masp
end
